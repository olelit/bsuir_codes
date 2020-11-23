using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SPP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Создаем класс куда парсить инфу из текст файла
        public class car
        {
            public string   avto { get; set; }
            public int      price { get; set; }
            public int      year { get; set; }
            public string   photo { get; set; }
        }

        //Достаем инфу из текст файла и создаем массив из машин по этой инфе
        public static List<car> load_data()
        {
            using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}\\datebase.txt")) //читаем текст файл
            {
                var elements = sr.ReadToEnd().Replace("\r\n", string.Empty); //удаляем переносы

                var rawStrings = elements.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries); //разбиваем по строкам

                List<car> Cars = new List<car>(); //создаем лист машин на основе класса car


                //добавление машины в лист
                foreach (var el in rawStrings)
                {
                    var a = el.Split(',');
                    var name = a[0].Split(':').Last().Trim();
                    var price = a[1].Split(':').Last().Trim();
                    var year = a[2].Split(':').Last().Trim();
                    var photo = a[3].Split(':').Last().Trim();

                    car CarToAdd = new car
                    {
                        avto = name,
                        price = Convert.ToInt32(price),
                        year = Convert.ToInt32(year),
                        photo = photo,
                    };

                    Cars.Add(CarToAdd);
                }
                return Cars;
            }
        }


        //заполнение дата грида
        public void fill_data (List<car> Cars)
        {
            dataGridView1.Rows.Clear();

            foreach (var car in Cars)
            {
                dataGridView1.Rows.Add(car.avto,car.price,car.year,car.photo);
            }
        }

        //кнопка заполнения дата грида
        private void button1_Click(object sender, EventArgs e)
        {
            var Cars = load_data();

            fill_data(Cars);

        }

        //ивент по которому выводится картинка кликнутой в дата гриде машины
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var image = dataGridView1.CurrentRow.Cells[3].Value;

            pictureBox1.Image = new Bitmap($"{Directory.GetCurrentDirectory()}\\{image}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //работа с фильтрами
        private void button2_Click(object sender, EventArgs e)
        {
            var Cars = load_data();

            dataGridView1.Rows.Clear(); //очистка дата грида

            //LINQ поиск всех записией в листе по условиям price<= condition1 year >= condition2.
            var CarsToDisplay = Cars.Where(r => r.price <= Convert.ToInt32(textBox1.Text) && r.year >= Convert.ToInt32(textBox2.Text));


            //вывод машин удовлетворяющих условиям
            foreach (var car in CarsToDisplay)
            {
                dataGridView1.Rows.Add(car.avto, car.price, car.year, car.photo);
            }

        }
    }
}
