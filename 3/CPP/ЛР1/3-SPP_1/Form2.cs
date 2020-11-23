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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Получение названия книги
            string selected = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
            string[] lines = System.IO.File.ReadAllLines("f.txt");
            for (int i=0; i < lines.Length-1; i++)
            {
                //если название книги совпадает вывод инфы
                if (selected.Equals(lines[i]))
                {
                    label1.Text = lines[i + 1]; 
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
