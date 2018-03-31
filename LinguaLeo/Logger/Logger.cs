using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LinguaLeo.Interfaces;

namespace LinguaLeo.Logs
{
    class Logger : ILogger
    {
        public List<string> logger;
        private TextBox logTB;

        public Logger(TextBox logStr)
        {
            logger = new List<string>();
            this.logTB = logStr;
        }

        public void Add(string line)
        {
            logger.Add(line + Environment.NewLine);
            this.logTB.Text += line + Environment.NewLine;
        }

        public void Clear()
        {
            logger.Clear();
            this.logTB.Text = "";
        }

        public void NewLine()
        {
            logger.Add(Environment.NewLine);
            this.logTB.Text += Environment.NewLine;
        }
    }
}
