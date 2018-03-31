using System;
using LinguaLeo.Api;
using LinguaLeo.Reader;
using LinguaLeo.Logs;
using LinguaLeo.Serialization;
using LinguaLeo.Forms;
using System.Windows.Forms;

namespace LinguaLeo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
