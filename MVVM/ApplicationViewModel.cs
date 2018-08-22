using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        #region  База
        private Employer selectedEmployer;

        public ObservableCollection<Employer> Employers { get; set; }
        public Employer SelectedEmployer
        {
            get { return selectedEmployer; }
            set
            {
                selectedEmployer = value;
                OnPropertyChanged("SelectedEmployer");
            }
        }
        private Departament selectedDepartament;
        public ObservableCollection<Departament> Departaments { get; set; }
        public Departament SelectedDepartament
        {
            get { return selectedDepartament; }
            set
            {
                this.selectedDepartament = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Selected Departament"));
            }
        }
        #endregion

        public ApplicationViewModel()
            {
            //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB;
                               Initial Catalog = Lesson7;
            Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT [​Name],Surname,[​Age],[​Salary] FROM People", connection); // выборка из БД
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            //DataContext = dataTable.DefaultView; // - название Листвьюшки

            //command = new SqlCommand("DELETE FROM People  WHERE ID = @ID", connection);
            //SqlParameter parameter = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

            //parameter.SourceVersion = DataRowVersion.Original;

            //DeleteButton.Click += (sender, args) => // название кнопки удаления
            //{
            //    DataRowView rowView = (DataRowView)Employers.SelectedItem; // название Листвьюшки
            //    rowView.Delete();
            //    adapter.Update(dataTable);
            //}




            }

    #region RelayCommands
    //private RelayCommand addEmployer;
    //public RelayCommand AddEmployer
    //{
    //    get
    //    {
    //        return addEmployer ??
    //            (addEmployer = new RelayCommand(obj =>
    //            {
    //                Employer employer = new Employer();
    //                Employers.Insert(0, employer);
    //                SelectedEmployer = employer;
    //            }));
    //    }
    //}


    //public void RemoveEmployer()
    //{
    //    MessageBox.Show("RemoveE");
    //}

    //private RelayCommand addDepartament;
    //public RelayCommand AddDepartament
    //{
    //    get
    //    {
    //        return addDepartament ??
    //            (addDepartament = new RelayCommand(obj =>
    //            {
    //                Departament departament = new Departament { Name = "Департамент" };
    //                Departaments.Insert(0, departament);
    //                selectedDepartament = departament;
    //            }));
    //    }
    //}
    //public void RemoveDepartament()
    //{
    //    MessageBox.Show("RemoveD");
    //}

    #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}