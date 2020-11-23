using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3_SPP_1
{
    public partial class Form6 : Form
    {
        private int i = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i += 1;
            Graphics g = Graphics.FromHwnd(Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(255, 255);

            string[] fileEntries = Directory.GetFiles(@"C:\Users\antik\Pictures\Pictures");
            foreach (string fileName in fileEntries)
                imageList1.Images.Add(Image.FromFile(fileName));

            imageList1.Draw(g, new Point(40, 40), i);

        }

        private void Form6_Load(object sender, EventArgs e)
       
        {
            Graphics g = Graphics.FromHwnd(Handle);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(256, 200);

            string[] fileEntries = Directory.GetFiles(@"C:\Users\Nathan\Desktop\univer\SPP\pictures");
            foreach (string fileName in fileEntries)
                imageList1.Images.Add(Image.FromFile(fileName));

            imageList1.Draw(g, new Point(40, 40), i);
        }
    }
}
