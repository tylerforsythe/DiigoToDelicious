using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using CsvHelper;

namespace DiigoToDelicious
{
    public class DeliciousApiWrapper
    {
        private DateTime? _resumeProcessingAt = null;
        private string _accessToken = "";
        private int _throttleRunningCount = 0; // if we get throttled more than X times in a row, we should just halt.
        private Queue<ImportRecord> _diigoCsvRecordsToImport = new Queue<ImportRecord>();


        public DeliciousApiWrapper(string accessToken) {
            _accessToken = accessToken;
        }


        private bool CheckForThrottle(string response) {
            return response.Contains("The remote server returned an error: (500)") ||
                response.Contains("The remote server returned an error: (503)") ||
                response.Contains("The remote server returned an error: (999)");
        }

        public void QueueRequest(ImportRecord csvImportRecord) {
            _diigoCsvRecordsToImport.Enqueue(csvImportRecord);
        }

        public bool HasRequestQueued() {
            return _diigoCsvRecordsToImport.Count > 0;
        }

        public int RemainingQueue() {
            return _diigoCsvRecordsToImport.Count;
        }

        private bool IsThrottled() {
            if (_resumeProcessingAt == null)
                return false;
            return DateTime.Now < _resumeProcessingAt;
        }

        public string RunRequest() {
            if (IsThrottled()) {
                //We're waiting on a throttle. Simmer down.
                return "throttled";
            }

            var currentRecord = _diigoCsvRecordsToImport.Peek(); //get the next item but leave it in the queue until success
            string urlForPost = "https://api.del.icio.us/v1/posts/get";
            var response = Http.Get(urlForPost, new NameValueCollection()
            {
                {"url", HttpUtility.UrlEncode(currentRecord.url)}
            },
            _accessToken);

            if (CheckForThrottle(response)) {
                _resumeProcessingAt = DateTime.Now.AddSeconds(5);
                ++_throttleRunningCount;
                return "throttled 2  " + response;
            }

            //needs imported
            if (response.Contains("code=\"no bookmarks\"")) {
                Thread.Sleep(2200);
                urlForPost = "https://api.del.icio.us/v1/posts/add";

                //byte[] bytes = Encoding.Default.GetBytes(currentRecord.title ?? "");
                //var titleOutput = Encoding.UTF8.GetString(bytes);
                //bytes = Encoding.Default.GetBytes(currentRecord.description ?? "");
                //var descriptionOutput = Encoding.UTF8.GetString(bytes);

                var titleOutput = EncodeForTransferHtmlEncode(currentRecord.title ?? "");  //HttpUtility.UrlEncode
                var descriptionOutput = EncodeForTransferHtmlEncode(currentRecord.description ?? "");

                response = Http.Post(urlForPost, new NameValueCollection()
                {
                    {"url", currentRecord.url},
                    {"description", titleOutput},
                    {"extended", descriptionOutput},
                    {"tags", currentRecord.tags},
                    {"dt", currentRecord.addedDT.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                    {"replace", "no"},
                    {"shared", currentRecord.isPrivate ? "no" : "yes"}
                },
                _accessToken);

                if (response.Contains("<result code=\"done\"/>")) {
                    //we're good
                    _throttleRunningCount = 0;
                    _resumeProcessingAt = null;
                    _diigoCsvRecordsToImport.Dequeue(); //actually remove the item from the queue
                }
                else if (CheckForThrottle(response)) {
                    _resumeProcessingAt = DateTime.Now.AddSeconds(61);
                    ++_throttleRunningCount;
                    return "throttled 3  " + response;
                }
                else if (response.Contains("throttled") || response.Contains("The remote server returned an error: (401) Unauthorized.")) {
                    _resumeProcessingAt = DateTime.Now.AddSeconds(61);
                    ++_throttleRunningCount;
                    return "throttled 401  " + response;
                }
                else if (response.Contains("<result code=\"item already exists\"/>")) {
                    _diigoCsvRecordsToImport.Dequeue(); //actually remove the item from the queue
                    return "definitely already exists   " + response;
                }
                else {
                    //unknown, but not successful
                    //log it to a CSV, dequeue, and move on
                    AddToErrorCSV(currentRecord);
                    _diigoCsvRecordsToImport.Dequeue();
                }

                return response;
            }
            else if (CheckForThrottle(response) || 
                    response.ToLower().Contains("throttled") || 
                    response.Contains("The remote server returned an error: (401) Unauthorized.") ||
                    response.ToLower().Contains("unauthorized")) {
                _resumeProcessingAt = DateTime.Now.AddSeconds(61);
                ++_throttleRunningCount;
                return "throttled (2) 401  " + response;
            }
            //skip
            else {
                _diigoCsvRecordsToImport.Dequeue(); //actually remove the item from the queue
                return "already exists I think   " + response;
            }
        }

        private static string EncodeForTransferHtmlEncode(string input) {
            //System.Web.HttpUtility.HtmlEncode("This is a test one ²")

            //return System.Web.HttpUtility.HtmlEncode(input);

            byte[] bytes = Encoding.Default.GetBytes(input);
            var output = Encoding.UTF8.GetString(bytes);

            return output;

            //return System.Web.HttpUtility.HtmlEncode(input);
            //return HttpUtility.UrlEncode(output);
            return input;
        }

        private static void AddToErrorCSV(ImportRecord r) {
            var outStream = new StreamWriter("error_out3.csv", true);
            var csv = new CsvWriter(outStream);
            csv.WriteRecord(r);
            csv.Dispose();
            outStream.Close();
        }
    }
}
