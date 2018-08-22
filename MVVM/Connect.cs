//using System;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;
//using System.Data;

//namespace ConsoleApp1
//{
//    class Connect
//    {
//        static void DB()
//        {
//            Random random = new Random();

//            // добавление 
//            //var employer = new Employer
//            //{
//            //    Name = $"Name{random.Next(0, 100)}",
//            //    Surname = $"Surname{random.Next(1, 28)}.{random.Next(1, 12)}.{random.Next(1992, 2017)}",
//            //    Age = random.Next(25, 65),
//            //    Salary = random.Next(20000, 35000)
//            //};
//            //var sql = $@"INSERT INTO People (Name,Surname,Age,Salary) VALUES ('{employer.Name}','{employer.Surname}','{employer.Age}','{employer.Salary}'"; //забиваем БД данными

//            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

//            SqlConnection connection = new SqlConnection();
//            SqlDataAdapter adapter = new SqlDataAdapter();
//            SqlCommand command = new SqlCommand("SELECT Name,Surname,Age,Salary FROM People", connection); // выборка из БД
//            adapter.SelectCommand = command;
//            DataTable dataTable = new DataTable();
//            adapter.Fill(dataTable);
//            Employers.DataContext = dataTable.DefaultView; // - название Листвьюшки

//            command = new SqlCommand("DELETE FROM People  WHERE ID = @ID", connection);
//            SqlParameter parameter = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

//            parameter.SourceVersion = DataRowVersion.Original;
//            DeleteButton.Click += (sender,args) => // название кнопки удаления
//            {
//                DataRowView rowView = (DataRowView)Employers.SelectedItem; // название Листвьюшки
//                rowView.Delete();
//                adapter.Update(dataTable);
//            }








//            //#region Запись

            
//            //var sql = $@"INSERT INTO People (Fio,Birthday,Email,Phone) VALUES (N'{employer.Name}','{employer.Surname}','{employer.Age}','{employer.Salary}'";
//            //using (SqlConnection connection = new SqlConnection(connectionString))
//            //{
//            //    connection.Open();
//            //    SqlCommand command = new SqlCommand(sql, connection);
//            //    command.ExecuteNonQuery();


//            //}

//            //#endregion

//        //    #region Чтение

//        //    try
//        //    {
//        //        using (SqlConnection connection = new SqlConnection(connectionString))
//        //        {
//        //            connection.Open();
//        //            var sql = @"SELECT * FROM People";
//        //            SqlCommand command = new SqlCommand(sql, connection);
//        //            SqlDataReader reader = command.ExecuteReader();
//        //            while (reader.Read())
//        //            {
//        //                Console.WriteLine();
//        //            }
//        //        }
//        //    }
//        //    #endregion
//        }

//    }
//}
