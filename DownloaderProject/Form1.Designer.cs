
namespace DownloaderProject
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.Label();
            this.percentText = new System.Windows.Forms.Label();
            this.downloadedText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Downloaded :\r\n";
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Location = new System.Drawing.Point(105, 196);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(42, 13);
            this.speedText.TabIndex = 7;
            this.speedText.Text = "0 MB/s";
            // 
            // percentText
            // 
            this.percentText.AutoSize = true;
            this.percentText.Location = new System.Drawing.Point(714, 75);
            this.percentText.Name = "percentText";
            this.percentText.Size = new System.Drawing.Size(21, 13);
            this.percentText.TabIndex = 6;
            this.percentText.Text = "0%\r\n";
            this.percentText.Click += new System.EventHandler(this.label6_Click);
            // 
            // downloadedText
            // 
            this.downloadedText.AutoSize = true;
            this.downloadedText.Location = new System.Drawing.Point(105, 166);
            this.downloadedText.Name = "downloadedText";
            this.downloadedText.Size = new System.Drawing.Size(32, 13);
            this.downloadedText.TabIndex = 5;
            this.downloadedText.Text = "0 MB";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(105, 57);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(25, 13);
            this.statusText.TabIndex = 4;
            this.statusText.Text = "......";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(105, 18);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(628, 20);
            this.urlText.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(105, 91);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(628, 23);
            this.progressBar.TabIndex = 9;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(556, 129);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(452, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(658, 129);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 12;
            this.btnResume.Text = "&Resume\r\n";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.percentText);
            this.Controls.Add(this.downloadedText);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Downloader ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Label percentText;
        private System.Windows.Forms.Label downloadedText;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResume;
    }
}

