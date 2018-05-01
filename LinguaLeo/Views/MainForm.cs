using System;
using LinguaLeo.Logs;
using LinguaLeo.Api;
using LinguaLeo.Serialization;
using System.Windows.Forms;
using LinguaLeo.Reader;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LinguaLeo.Controller;

namespace LinguaLeo.Forms
{
    public partial class MainForm : Form
    {
        MainFormController controller;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Log_Click(null, null);
            controller = new MainFormController(this.progressBar1,this.LoggerBox);
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            controller.Auth(this.Email.Text, this.Password.Text);
            if (!this.LoggerBox.Visible)
                Log_Click(null, null);

        }

        private void Log_Click(object sender, EventArgs e)
        {
            this.Width -= this.Width == 619 ? this.LoggerBox.Width : -this.LoggerBox.Width;
            this.LoggerBox.Visible = this.LoggerBox.Visible ? false : true;
            this.Email.Focus();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var words = controller.OpenFile();

            this.WordsCounter.Text = words.Count.ToString();
            this.progressBar1.Maximum = Convert.ToInt32(this.WordsCounter.Text);
            this.progressBar1.Value = 0;
            this.Enabled = true;
        }

        private static bool check = false;
        private void ImportWords_Click(object sender, EventArgs e)
        {
            if (!this.LoggerBox.Visible)
                Log_Click(null, null);

            if (Serrialize.isAuthed)
            {
                check = false;
                OpenFile_Click(null, null);

                Thread th;
                if (Convert.ToInt32(WordsCounter.Text) == 1)
                {
                    th = new Thread(controller.AddWord);
                    th.Start();
                }
                else if (Convert.ToInt32(WordsCounter.Text) >= 2)
                {
                    th = new Thread(controller.AddWords);
                    th.Start();
                }
            }
            else if(!check)
            {
                check = true;
                Auth_Click(null, null);
                ImportWords_Click(null, null);
            }

            this.LoggerBox.ScrollToCaret();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            check = false;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            check = false;
        }
    }
}
