using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Pen _Pen;

        SolidBrush Fon;

        SolidBrush Figure;

        const int Size = 60;
        Random rand;
        public Form1()
        {
            InitializeComponent();

            rand = new Random();
            _Pen = new Pen(Color.Yellow);
            Fon = new SolidBrush(Color.White);
            Figure = new SolidBrush(Color.Black);
            gr = pictureBox1.CreateGraphics();
        }

        //запуск анимации
        private void button1_Click(object sender, EventArgs e)
        {
            gr.FillRectangle(Fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
            int x, y;

            for (int i = 0; i < 5; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawRactangle(x, y);
            }

            timer1.Enabled = true;

        }

        void DrawRactangle(int x, int y)
        {
            int xn = x - Size;
            int yn = y - Size;
            gr.FillRectangle(Figure, xn, yn, Size, Size);

            gr.DrawRectangle(_Pen, xn, yn, Size, Size);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.FillEllipse(Fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
            int x, y;

            for (int i = 0; i < 5; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawRactangle(x, y);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
