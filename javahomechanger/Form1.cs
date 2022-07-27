using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace javahomechanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        string[] javapaths;

        private void Form1_Load(object sender, EventArgs e)
        {
            javapaths = Directory.GetDirectories(@"C:\Program Files\Java","*");
            path.Items.AddRange(javapaths);
            path.SelectedIndex = 0;
            addLog("今は[" + System.Environment.ExpandEnvironmentVariables("%JAVA_HOME%") + "]が設定されています");
        }

        void addLog(string s)
        {
            log.Text = log.Text + Environment.NewLine + s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Environment.SetEnvironmentVariable("JAVA_HOME", path.Text, EnvironmentVariableTarget.Machine);
            Process process = Process.Start("cmd.exe", "/c set");
            process.WaitForExit();
            process.Close();
            addLog("[" + path.Text + "]に設定しました");
        }
    }
}
