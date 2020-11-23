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
    public partial class Form7 : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        private int arrow = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void lblRght_Click(object sender, EventArgs e)
        {
            lblRght.Visible = false;
            lblLft.Visible = true;
            arrow = 1;
            textBoxRu.Clear();
            textBoxEng.Clear();
            textBoxRu.ReadOnly = true;
            textBoxEng.ReadOnly = false;
            lblLft.Enabled = true;
            lblRght.Enabled = false;
        }

        private void lblLft_Click(object sender, EventArgs e)
        {
            lblRght.Visible = true;
            lblLft.Visible = false;
            arrow = 0;
            textBoxRu.Clear();
            textBoxEng.Clear();
            textBoxRu.ReadOnly = false;
            textBoxEng.ReadOnly = true;
            lblLft.Enabled = false;
            lblRght.Enabled = true;
            
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (arrow == 0)
            {
                if (dict.ContainsKey(textBoxRu.Text.ToLower()))
                {
                    textBoxEng.Text = dict[textBoxRu.Text.ToLower()];
                    
                }
                
            }
            else
            {
                if (dict.ContainsValue(textBoxEng.Text.ToLower()))
                {
                    textBoxRu.Text = dict.FirstOrDefault(x => x.Value == textBoxEng.Text.ToLower()).Key;
                    
                }
               
            }
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            dict.Add("один","one");
            dict.Add("два", "two");
            dict.Add("три", "three");
            dict.Add("четыре", "four");
            dict.Add("пять", "five");
            dict.Add("шесть", "six");
            dict.Add("семь", "seven");
            dict.Add("восемь", "eight");
            dict.Add("девять", "nine");
            dict.Add("десять", "ten");
        }
    }
}
