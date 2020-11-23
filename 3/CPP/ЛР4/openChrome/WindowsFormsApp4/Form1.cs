using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public event Action<string> OnFileReaded;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.Start(
                @"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = openFileDialog1.FileName;
            var fileContent = File.ReadAllText(fileName);
            OnFileReaded?.Invoke(fileContent);
        }
    }



}
