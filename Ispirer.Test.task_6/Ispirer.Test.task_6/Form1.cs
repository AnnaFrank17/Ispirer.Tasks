using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ispirer.Test.task_6.Properties;

namespace Ispirer.Test.task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.lang);
            InitializeComponent();
            button1.Text = Resources.Button;
            label1.Text = Resources.Label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.lang = Settings.Default.lang.Equals("en-US") ? "ru-RU" : "en-US";
            Settings.Default.Save();
            Application.Restart();
        }
    }
}
