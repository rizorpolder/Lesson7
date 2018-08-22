using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // DataContext = new ApplicationViewModel();
            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                                    Initial Catalog = Lesson7;
                                    Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT [​Name],Surname,[​Age],[​Salary] FROM People", connection); // выборка из БД
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataView dataView = new DataView(dataTable);
            Employers.ItemsSource = dataTable.DefaultView;
            command = new SqlCommand("SELECT [​Departs] FROM Departament", connection); // выборка из БД
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DepCombo.ItemsSource = dt.DefaultView;


        }
    }
}
