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
    public partial class Form3 : Form
    {
        Graphics g;
        public Form3()
        {
            InitializeComponent();         
        }

        //функция обновления 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        //изменение высоты
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(Pens.Black, new Rectangle(10, 175-trackBar1.Value, 100, trackBar1.Value));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawEllipse(Pens.Green, new Rectangle(10, 175-trackBar2.Value, trackBar2.Value, trackBar2.Value));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            panel2.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            panel3.Refresh();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
         
            float x1 = 0;
            float y1 = 0;

            float y2 = 0;


            float yEx = 100;
         
            float eF = 30;

            for (float x = 0; x < 30; x+=0.1F)
            {
                y2 = (float)Math.Sin(x*(trackBar3.Value/10));
                
                g.DrawLine(Pens.Red, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);
                x1 = x;
                y1 = y2;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
