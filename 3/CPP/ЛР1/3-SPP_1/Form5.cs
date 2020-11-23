using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_SPP_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            //вызов фонт диалога для изменения параметров шрифта
            if(fontDialog.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                if (String.IsNullOrEmpty(richTextBox1.SelectedText))
                {
                    richTextBox1.Font = fontDialog.Font;
                    richTextBox1.ForeColor = fontDialog.Color;
                }
                else //для всего
                {
                    richTextBox1.SelectionFont = fontDialog.Font;
                    richTextBox1.SelectionColor = fontDialog.Color;
                }
                
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
