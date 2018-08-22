using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lesson7;Integrated Security=True;";
            try { 
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                    var departament = new Departament
                    {
                        Name = $"Departament_{random.Next(0, 100)}"
                    };
                    var sqld = $@"INSERT INTO Departament ([​Departs]) VALUES ('{departament.Name}')"; //забиваем БД данными

                    var employer = new Employer
                    {
                        Name = $"Name_{random.Next(0, 100)}",
                        Surname = $"Surname_{random.Next(1, 28)}",
                        Age = random.Next(25, 65),
                        Salary = random.Next(20000, 35000),
                    };
                    var sql = $@"INSERT INTO People ( [​Name], [Surname] , [​Age] , [​Salary]) VALUES ('{employer.Name}','{employer.Surname}','{employer.Age}','{employer.Salary}')"; //забиваем БД данными

                    Console.WriteLine(sql);
                    Console.WriteLine();
                    Console.WriteLine(sql);
                Console.WriteLine();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqld, connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(sqld, connection);
                        command.ExecuteNonQuery();
                    }
                }
               }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("exit");
            }
            Console.ReadLine();
        }
    }
}
