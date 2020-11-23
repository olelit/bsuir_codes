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
using System.Xml.Linq;

namespace SPP7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Phone
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();
            // создаем первый элемент
            XElement test = new XElement("test");
            // создаем атрибут
            XAttribute testNameAttr = new XAttribute("test_name", "T1");
            XElement test_CompanyElem = new XElement("test_company", "T_Company");
            XElement test_PriceElem = new XElement("test_price", "111");
            // добавляем атрибут и элементы в первый элемент
            test.Add(testNameAttr);
            test.Add(test_CompanyElem);
            test.Add(test_PriceElem);

            // создаем второй элемент
            XElement test2 = new XElement("phone");
            XAttribute galaxysNameAttr = new XAttribute("test_name", "T2");
            XElement galaxysCompanyElem = new XElement("test_company", "T_comp_2");
            XElement galaxysPriceElem = new XElement("test_price", "222");
            test2.Add(galaxysNameAttr);
            test2.Add(galaxysCompanyElem);
            test2.Add(galaxysPriceElem);
            // создаем корневой элемент
            XElement tests = new XElement("tests");
            // добавляем в корневой элемент
            tests.Add(test);
            tests.Add(test2);
            // добавляем корневой элемент в документ
            xdoc.Add(tests);
            //сохраняем документ
            xdoc.Save("phones.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", Path.GetFullPath("phones.xml"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            var items = from xe in xdoc.Element("tests").Elements("test")
                        where xe.Element("test_company").Value == textBox1.Text
                        select new Phone
                        {
                            Name = xe.Attribute("test_name").Value,
                            Price = xe.Element("test_price").Value
                        };

            foreach (var item in items)
               MessageBox.Show($"{item.Name} - {item.Price}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
