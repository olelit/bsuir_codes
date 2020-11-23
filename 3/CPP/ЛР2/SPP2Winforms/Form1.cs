using System;
using System.Windows.Forms;

namespace SPP2Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //загрузить данные в таблицу "sPPLR2DataSet.Users".
            this.usersTableAdapter.Fill(this.sPPLR2DataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SPPLR2Entities context = new SPPLR2Entities())
            {
                //создание объекта юзера
                Users user = new Users
                {
                    Email = textBox1.Text,
                    Username = textBox3.Text,
                    password = textBox2.Text,
                };

                //Добавление юзера
                context.Users.Add(user);
                context.SaveChanges();

            }
        }
    }
}
