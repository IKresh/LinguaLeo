namespace LinguaLeo.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenFile = new System.Windows.Forms.Button();
            this.ImportWords = new System.Windows.Forms.Button();
            this.LoggerBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Auth = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WordsCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(292, 131);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ImportWords
            // 
            this.ImportWords.Location = new System.Drawing.Point(292, 165);
            this.ImportWords.Name = "ImportWords";
            this.ImportWords.Size = new System.Drawing.Size(75, 23);
            this.ImportWords.TabIndex = 1;
            this.ImportWords.Text = "ImportWords";
            this.ImportWords.UseVisualStyleBackColor = true;
            this.ImportWords.Click += new System.EventHandler(this.ImportWords_Click);
            // 
            // LoggerBox
            // 
            this.LoggerBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoggerBox.Location = new System.Drawing.Point(395, 0);
            this.LoggerBox.Multiline = true;
            this.LoggerBox.Name = "LoggerBox";
            this.LoggerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LoggerBox.Size = new System.Drawing.Size(208, 199);
            this.LoggerBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LinguaLeo.Properties.Resources.Leo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 95);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(63, 17);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(178, 20);
            this.Login.TabIndex = 4;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Auth);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.Auth.Location = new System.Drawing.Point(168, 69);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(75, 23);
            this.Auth.TabIndex = 6;
            this.Auth.Text = "Auth";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(63, 43);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(178, 20);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Words founded:";
            // 
            // WordsCounter
            // 
            this.WordsCounter.AutoSize = true;
            this.WordsCounter.Location = new System.Drawing.Point(266, 136);
            this.WordsCounter.Name = "WordsCounter";
            this.WordsCounter.Size = new System.Drawing.Size(13, 13);
            this.WordsCounter.TabIndex = 7;
            this.WordsCounter.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Right;
            this.Log.Location = new System.Drawing.Point(375, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(20, 199);
            this.Log.TabIndex = 9;
            this.Log.Text = ">";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 199);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.WordsCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoggerBox);
            this.Controls.Add(this.ImportWords);
            this.Controls.Add(this.OpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button ImportWords;
        private System.Windows.Forms.TextBox LoggerBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Auth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WordsCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Log;
    }
}