using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiigoToDelicious
{
    public static class Http
    {
        public static string Post(string uri, NameValueCollection pairs, string accessToken = null) {
            byte[] response = null;
            using (var client = new WebClient()) {
                if (!string.IsNullOrEmpty(accessToken))
                    client.Headers.Add("Authorization" ,"Bearer " + accessToken);

                client.Encoding = Encoding.UTF8;
                client.Headers.Add("user-agent", "DiigoToDeliciousImporter Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                try {
                    response = client.UploadValues(uri, pairs);
                }
                catch (System.Net.WebException webex) {
                    return webex.Message;
                }
            }
            string result = System.Text.Encoding.UTF8.GetString(response);
            return result;
        }
        public static string Get(string uri, NameValueCollection pairs, string accessToken = null) {
            string result = null;

            using (var client = new WebClient()) {
                if (!string.IsNullOrEmpty(accessToken))
                    client.Headers.Add("Authorization", "Bearer " + accessToken);

                client.Encoding = Encoding.UTF8;

                foreach (var key in pairs.AllKeys) {
                    //client.QueryString.Add("param1", "value1");
                    client.QueryString.Add(key, pairs[key]);
                }

                try {
                    result = client.DownloadString(uri);
                }
                catch (System.Net.WebException webex) {
                    return webex.Message;
                }
            }
            return result;
        }
    }
}
