namespace DiigoToDelicious
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtRedirectUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrantType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRedirectUrl2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDiigoFilePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTestGet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGetUrl = new System.Windows.Forms.TextBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenAndProcessFile = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnPauseProcess = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redirect URL:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(103, 18);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(240, 20);
            this.txtClientId.TabIndex = 2;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // txtRedirectUrl
            // 
            this.txtRedirectUrl.Location = new System.Drawing.Point(103, 46);
            this.txtRedirectUrl.Name = "txtRedirectUrl";
            this.txtRedirectUrl.Size = new System.Drawing.Size(240, 20);
            this.txtRedirectUrl.TabIndex = 3;
            this.txtRedirectUrl.Text = "www.example.com";
            this.txtRedirectUrl.TextChanged += new System.EventHandler(this.txtRedirectUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL to Copy-Paste:";
            // 
            // txtAuthUrl
            // 
            this.txtAuthUrl.Location = new System.Drawing.Point(375, 31);
            this.txtAuthUrl.Name = "txtAuthUrl";
            this.txtAuthUrl.Size = new System.Drawing.Size(481, 20);
            this.txtAuthUrl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OAuth";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(106, 121);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(240, 20);
            this.txtClientSecret.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client Secret:";
            // 
            // txtGrantType
            // 
            this.txtGrantType.Location = new System.Drawing.Point(106, 149);
            this.txtGrantType.Name = "txtGrantType";
            this.txtGrantType.Size = new System.Drawing.Size(240, 20);
            this.txtGrantType.TabIndex = 12;
            this.txtGrantType.Text = "code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Grant Type:";
            // 
            // txtRedirectUrl2
            // 
            this.txtRedirectUrl2.Location = new System.Drawing.Point(106, 181);
            this.txtRedirectUrl2.Name = "txtRedirectUrl2";
            this.txtRedirectUrl2.Size = new System.Drawing.Size(240, 20);
            this.txtRedirectUrl2.TabIndex = 14;
            this.txtRedirectUrl2.Text = "www.example.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Redirect URL:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(106, 213);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(240, 20);
            this.txtCode.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(596, 184);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(503, 301);
            this.txtResult.TabIndex = 18;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(106, 246);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 19;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pick Diigo File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiigoFilePath
            // 
            this.txtDiigoFilePath.Location = new System.Drawing.Point(681, 116);
            this.txtDiigoFilePath.Name = "txtDiigoFilePath";
            this.txtDiigoFilePath.Size = new System.Drawing.Size(403, 20);
            this.txtDiigoFilePath.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(678, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Diigo File";
            // 
            // btnTestGet
            // 
            this.btnTestGet.Location = new System.Drawing.Point(398, 400);
            this.btnTestGet.Name = "btnTestGet";
            this.btnTestGet.Size = new System.Drawing.Size(75, 23);
            this.btnTestGet.TabIndex = 23;
            this.btnTestGet.Text = "Test Get";
            this.btnTestGet.UseVisualStyleBackColor = true;
            this.btnTestGet.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Get URL:";
            // 
            // txtGetUrl
            // 
            this.txtGetUrl.Location = new System.Drawing.Point(103, 374);
            this.txtGetUrl.Name = "txtGetUrl";
            this.txtGetUrl.Size = new System.Drawing.Size(370, 20);
            this.txtGetUrl.TabIndex = 25;
            this.txtGetUrl.Text = "http://andrewrussell.net/exen/";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(106, 308);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(240, 20);
            this.txtAccessToken.TabIndex = 27;
            this.txtAccessToken.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Access Token:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenAndProcessFile
            // 
            this.btnOpenAndProcessFile.Location = new System.Drawing.Point(1009, 142);
            this.btnOpenAndProcessFile.Name = "btnOpenAndProcessFile";
            this.btnOpenAndProcessFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAndProcessFile.TabIndex = 28;
            this.btnOpenAndProcessFile.Text = "Open";
            this.btnOpenAndProcessFile.UseVisualStyleBackColor = true;
            this.btnOpenAndProcessFile.Click += new System.EventHandler(this.btnOpenAndProcessFile_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(638, 516);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 29;
            this.btnProcess.Text = "Process Records";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnPauseProcess
            // 
            this.btnPauseProcess.Location = new System.Drawing.Point(770, 516);
            this.btnPauseProcess.Name = "btnPauseProcess";
            this.btnPauseProcess.Size = new System.Drawing.Size(75, 23);
            this.btnPauseProcess.TabIndex = 30;
            this.btnPauseProcess.Text = "Pause Process";
            this.btnPauseProcess.UseVisualStyleBackColor = true;
            this.btnPauseProcess.Click += new System.EventHandler(this.btnPauseProcess_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Processed:";
            // 
            // lblProcessed
            // 
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.Location = new System.Drawing.Point(23, 516);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(41, 13);
            this.lblProcessed.TabIndex = 32;
            this.lblProcessed.Text = "label14";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(121, 516);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(41, 13);
            this.lblRemaining.TabIndex = 34;
            this.lblRemaining.Text = "label15";
            this.lblRemaining.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 487);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Remaining:";
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(871, 516);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 35;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1009, 516);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 36;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 672);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblProcessed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPauseProcess);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnOpenAndProcessFile);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGetUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTestGet);
            this.Controls.Add(this.txtDiigoFilePath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRedirectUrl2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrantType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRedirectUrl);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diigo to Delicious";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtRedirectUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrantType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRedirectUrl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiigoFilePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTestGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGetUrl;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenAndProcessFile;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnPauseProcess;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblProcessed;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnStop;
    }
}

