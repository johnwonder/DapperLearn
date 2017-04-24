using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=cloudlin;Uid=root;Pwd=root;";

            IDbConnection dbcon =  conn;


            Category cate = new Category();
            cate.name = "纸头";
            cate.level = 0;
            string query = "INSERT INTO category(name)VALUES(@name)";
            dbcon.Execute(query, cate);
        }
    }

    class Category
    {
        public int id { get; set; }

        public string name { get; set; }

        public string dimension { get; set; }

        public double weight { get; set; }

        public int weightUnit { get; set; }

        public double unitPrice { get; set; }

        public int priceUnit { get; set; }

        public int color { get; set; }

        
        public int level { get; set; }

        public int parent { get; set; }

        public int num { get; set; }

        public int numUnit { get; set; }
    }
}
