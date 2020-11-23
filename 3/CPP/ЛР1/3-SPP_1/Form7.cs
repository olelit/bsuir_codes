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

        private void Form7_Shown(object sender, EventArgs e)
        {
            //добавление слов в словарь
            dict.Add("это", "it");
            dict.Add("дом", "house");
            dict.Add("буквально", "literally");
            dict.Add("почему", "why");
            dict.Add("прыгать", "jamp");

        }

        //cмена на перевод с англ на ру
        private void lblRght_Click(object sender, EventArgs e)
        {
            lblRght.Visible = false;
            lblLft.Visible = true;
            btnTranslate.Text = "Translate";
            arrow = 1;
            textBoxRu.Clear();
            textBoxEng.Clear();
            textBoxRu.ReadOnly = true;
            textBoxEng.ReadOnly = false;
            lblLft.Enabled = true;
            lblRght.Enabled = false;
            lblErr.Text = "Not Found";
            lblErr.Visible = false;
        }

        //Смена на перевод с ру на англ
        private void lblLft_Click(object sender, EventArgs e)
        {
            lblRght.Visible = true;
            lblLft.Visible = false;
            btnTranslate.Text = "Перевести";
            arrow = 0;
            textBoxRu.Clear();
            textBoxEng.Clear();
            textBoxRu.ReadOnly = false;
            textBoxEng.ReadOnly = true;
            lblLft.Enabled = false;
            lblRght.Enabled = true;
            lblErr.Text = "Не найдено";
            lblErr.Visible = false;
        }

        //поиск по словарю через linq и вывод перевода
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (arrow == 0)
            {
                if (dict.ContainsKey(textBoxRu.Text.ToLower()))
                {
                    textBoxEng.Text = dict[textBoxRu.Text.ToLower()];
                    lblErr.Visible = false;
                }
                else
                {
                    lblErr.Visible = true;
                }
            }
            else
            {
                if (dict.ContainsValue(textBoxEng.Text.ToLower()))
                {
                    textBoxRu.Text = dict.FirstOrDefault(x => x.Value == textBoxEng.Text.ToLower()).Key;
                    lblErr.Visible = false;
                }
                else
                {
                    lblErr.Visible = true;
                }
            }
        }

       

        private void lblHint_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
