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

namespace SPP_LR1
{
    public partial class Form1 : Form
    {
        //переменные калькулятора
        float a, b;
        int count;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }

        // ВАРИАНТ 1 ------------------------------------------------------------------------------------------------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                textBox1.Text = File.ReadAllLines("C:\\Users\\litasov\\Desktop\\spplr1.txt").Skip(0).First();
            else if (listBox1.SelectedIndex == 1)
                textBox1.Text = File.ReadAllLines("C:\\Users\\litasov\\Desktop\\spplr1.txt").Skip(1).First();
            else textBox1.Text = File.ReadAllLines("C:\\Users\\litasov\\Desktop\\spplr1.txt").Skip(2).First();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 130;
            Bitmap bmp = new Bitmap(1500, 600);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 3);

            graph.DrawRectangle(pen, 10, 150, trackBar1.Value/2, trackBar1.Value);

            pictureBox1.Image = bmp;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Maximum = 130;
            Bitmap bmp = new Bitmap(1500, 600);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 3);

            graph.DrawEllipse(pen, 10, 150, trackBar2.Value, trackBar2.Value);

            pictureBox2.Image = bmp;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Maximum = 130;
            Bitmap bmp = new Bitmap(1500, 600);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 3);


            PointF[] m_Sin;
            PointF[] m_Cos;
            List<PointF> sin = new List<PointF>();
            List<PointF> cos = new List<PointF>();
            for (float i = -1; i <= 1; i += 0.0001F)
            {
                sin.Add(
                    new PointF(
                        (float)(i * 1000 + 50.0),
                        (float)(Math.Sin(i * trackBar3.Value) * 50 + 50.0)
                    )
                );
                cos.Add(
                    new PointF(
                        (float)(i * 1000 + 50.0),
                        (float)(Math.Cos(i * trackBar3.Value) * 50 + 50.0)
                    )
                );
            }
            m_Sin = sin.ToArray();
            m_Cos = cos.ToArray();
            graph.DrawLines(Pens.Black, m_Sin);
            graph.DrawLines(Pens.Green, m_Cos);

            pictureBox3.Image = bmp;
        }
        //----------------------------------------------------------------------------------------------------------------------------

         //ВАРИАНТ 3--------------------------------------------------------------------------------------------       
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 3;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int lenght = textBox2.Text.Length - 1;
            string text = textBox2.Text;
            textBox2.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox2.Text = textBox2.Text + text[i];
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox2.Text);
            textBox2.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fd.Font;
        }

        public void UploadImage(PictureBox pictureBox)
        {
            Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    this.pictureBox4.Size = image.Size;
                    pictureBox.Image = image;
                    pictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            UploadImage(pictureBox5);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            UploadImage(pictureBox4);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++) {
                if ((textBox3.Text.ToLower() != Convert.ToString(listBox2.Items[i]).ToLower()) & (textBox3.Text.ToLower() != Convert.ToString(listBox3.Items[i]).ToLower())){
                    textBox4.Text = "Совпадений нет!";
                }
                else if (textBox3.Text.ToLower() == Convert.ToString(listBox2.Items[i]).ToLower())
                {
                    textBox4.Text = Convert.ToString(listBox3.Items[i]);
                    break;
                }
                else if (textBox3.Text.ToLower() == Convert.ToString(listBox3.Items[i]).ToLower())
                {
                    textBox4.Text = Convert.ToString(listBox2.Items[i]);
                    break;
                }             
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }




    }
}
