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
    public partial class Form4 : Form
    {
        private string frst = "";
        private int action;
        private int newCase = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Frst()
        {
            if (textBox1.Text.Equals(""))
            {
            }
            else
            {
                frst = textBox1.Text;
                textBox1.Clear();
            }
            newCase = 1;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            this.Frst();
            action = 1;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.Frst();
            action = 2;
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            this.Frst();
            action = 3;
        }

        private void BtnDvd_Click(object sender, EventArgs e)
        {
            this.Frst();
            action = 4;
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || newCase == 0)
            {
  
                textBox1.Clear();
                textBox1.Text = frst;              
            }
            else
            {
                string scnd = textBox1.Text;
                textBox1.Clear();
                switch (action)
                {
                    case 1:
                        textBox1.Text = ""+(float.Parse(frst) + float.Parse(scnd));
                        break;
                    case 2:
                        textBox1.Text = "" + (float.Parse(frst) - float.Parse(scnd));
                        break;
                    case 3:
                        textBox1.Text = "" + (float.Parse(frst) * float.Parse(scnd));
                        break;
                    case 4:
                        textBox1.Text = "" + (float.Parse(frst) / float.Parse(scnd));
                        break;
                    default:
                        break;
                }
                frst = textBox1.Text;
                newCase = 0;
            }
        }
    }
}
