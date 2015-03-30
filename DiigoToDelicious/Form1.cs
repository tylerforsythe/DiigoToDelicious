using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
/*
 * Set user-agent to something like DiigoToDeliciousGTF
 * Add some sort of queue to requests so I can handle throttling
 * Detect throttling and set a flag
 * Wait at least 1 second between requests by default
 * */
using CsvHelper;


namespace DiigoToDelicious
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        protected void UpdateAuthUrl() {
            txtAuthUrl.Text =
                string.Format(
                    "https://delicious.com/auth/authorize?client_id={0}&redirect_uri={1}",
                    txtClientId.Text, txtRedirectUrl.Text);
        }

        private void txtClientId_TextChanged(object sender, EventArgs e) {
            UpdateAuthUrl();
        }

        private void txtRedirectUrl_TextChanged(object sender, EventArgs e) {
            UpdateAuthUrl();
        }

        private void btnExecute_Click(object sender, EventArgs e) {
            //https://avosapi.delicious.com/api/v1/oauth/token?client_id=f5dad5a834775d3811cdcfd6a37af312&client_secret=7363879fee6c3ab0f93efbd24111ad34&grant_type=code&code=fa746b2eb266cab06f34fb7bc3d51160

            string urlForPost = "https://avosapi.delicious.com/api/v1/oauth/token";
            var response = Http.Post(urlForPost, new NameValueCollection()
            {
                {"client_id", txtClientId.Text},
                {"client_secret", txtClientSecret.Text},
                {"grant_type", txtGrantType.Text},
                {"redirect_uri", txtRedirectUrl2.Text},
                {"code", txtCode.Text}
            });

            txtResult.Text = response;

            /*
             * 70192c492b5e109073b774d76477c6cb

             {
             "pkg":null,
             "status":"success",
             "url":"http://avosapi.delicious.com/api/v1/oauth/token",
             "delta_ms":18,
             "server":"api5-del",
             "session":"1tjn64oadulpw1twu1x6aaq51l",
             "api_mgmt_ms":0,
             "version":"v1",
             "access_token":"747028-c65b93f03988ef5ae53b0d7b02936e21"
             }
             * */
        }

        //btnTestGet
        private void button2_Click(object sender, EventArgs e) {
            //string urlForPost = "https://avosapi.delicious.com/api/v1/posts/get";
            string urlForPost = "https://api.del.icio.us/v1/posts/get";
            var response = Http.Get(urlForPost, new NameValueCollection()
            {
                {"url", HttpUtility.UrlEncode(txtGetUrl.Text)}
            },
            txtAccessToken.Text);

            txtResult.Text = response;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        //Select Diigo file
        private void button1_Click(object sender, EventArgs e) {
            var result = openFileDialog1.ShowDialog();
            var strFileName = openFileDialog1.FileName;
            txtDiigoFilePath.Text = strFileName;
        }


        private System.Threading.Thread _workerThread;
        private IEnumerable<ImportRecord> _records;
        private DeliciousApiWrapper _deliciousApi;

        private void btnOpenAndProcessFile_Click(object sender, EventArgs e) {
            //var fileStream = File.OpenRead(txtDiigoFilePath.Text);
            //var readerStream = new StreamReader(fileStream);
            //var csv = new CsvReader(readerStream);
            //_records = csv.GetRecords<DiigoCsvRecord>();

            //_records = DeliciousFileReader.ReadRecords(txtDiigoFilePath.Text);

            var fileStream = File.OpenRead(txtDiigoFilePath.Text);
            var readerStream = new StreamReader(fileStream);
            var csv = new CsvReader(readerStream);
            _records = csv.GetRecords<ImportRecord>().ToList();
        }

        private void btnProcess_Click(object sender, EventArgs e) {
            if (_records == null || _records.Count() == 0) {
                MessageBox.Show("No records are available.", "No records", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtAccessToken.Text)) {
                MessageBox.Show("No access token.", "No access token", MessageBoxButtons.OK);
                return;
            }

            _deliciousApi = new DeliciousApiWrapper(txtAccessToken.Text);

            //create and start a new thread in the load event.
            //passing it a method to be run on the new thread.
            _workerThread = new System.Threading.Thread(ProcessRecords);
            _workerThread.Start();
        }

        private void btnPauseProcess_Click(object sender, EventArgs e) {
            //stop the thread.
            _workerThread.Suspend();
        }

        public void ProcessRecords() {
            foreach (var r in _records)
                _deliciousApi.QueueRequest(r);

            int loops = 0;

            while (_deliciousApi.HasRequestQueued()) {
                var result = _deliciousApi.RunRequest();
                ++loops;

                //you need to use Invoke because the new thread can't access the UI elements directly
                MethodInvoker mi = delegate()
                {
                    this.lblProcessed.Text = loops.ToString();
                    this.lblRemaining.Text = _deliciousApi.RemainingQueue().ToString();
                    this.txtResult.Text = result;
                };
                this.Invoke(mi);

                Thread.Sleep(1200);
            }
        }

        private void label15_Click(object sender, EventArgs e) {

        }

        private void btnResume_Click(object sender, EventArgs e) {
            _workerThread.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            _workerThread.Abort();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
