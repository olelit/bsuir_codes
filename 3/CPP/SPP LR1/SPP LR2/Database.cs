using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SPP_LR2
{
    class Database
    {
        const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=bookdb;Integrated Security=True";
        const string TableName = "Book";

        public List<Book> GetItems()
        {
            List<Book> result = new List<Book>();
            string sqlExpression = "Select * from " + TableName + ";";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
            return new List<Book>();
        }
    }
}
