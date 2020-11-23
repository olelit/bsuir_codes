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

namespace WindowsFormsApp1
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
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            textBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = openFileDialog1.FileName;
            var fileContent = File.ReadAllText(fileName);
            OnFileReaded?.Invoke(fileContent);
        }

        public Func<string, string> Encoder { get; set; }
        public TextEncoder(Func<string, string> encoder) : base()
        {
            Encoder = encoder;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var filename = saveFileDialog1.FileName;
            var encodedText = Encoder(textBox2.Text);
            System.IO.File.WriteAllText(filename, encodedText);
        }
    }
}
