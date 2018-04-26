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
using System.Data.Linq;
using System.Collections.ObjectModel;

namespace ProjectEndOfYear
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        S00167749Entities2 db = new S00167749Entities2();

        ObservableCollection<Person> StaffAndStudents = new ObservableCollection<Person>();
        List<MyStaff> staffList = new List<MyStaff>();
        List<MyStudentClass1> studentList = new List<MyStudentClass1>();

        public MainWindow()
        {
            GetDataFromDB();
            InitializeComponent();
            var query = from c in db.StaffTBLs
                        where c.Year == 1
                        select c;

            listboxDetails.ItemsSource = query.ToList();

           // createObjects();
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void ShowListOfPerson()
        {
            var query1 = from st in db.StudentTBLs
                         select new
                         {
                             st.Name,
                             st.ID
                         };

            var query2 = from sf in db.StaffTBLs
                         select new
                         {
                             sf.Name,
                             sf.ID
                         };

            //var nameList = query1 + query2;

            //StaffAndStudents.Add(query1.ToList());

            //listboxPerson.ItemsSource = name;


        }

        private void GetDataFromDB()
        {
            #region
            var student = from st in db.StudentTBLs
                          select new MyStudentClass1(st.ID, st.Name, (DateTime)st.DOB, st.Type, st.Department, st.Address);

            //var staff = from sf in db.StaffTBLs
            //             select new
            //             {
            //                 sf.Name,
            //                 sf.ID,
            //                 sf.DOB,
            //                 sf.Department,
            //                 sf.Type,
            //                 sf.Address,
            //                 sf.Salary,
            //                 sf.Year
            //             };
            #endregion

            student.ToList();

            //studentList.Add(student[0]);
            int studentLength = student.Count();
            MyStudentClass1[] studentArray = new MyStudentClass1[studentLength];

            for (int i = 0; i < student.Count(); i++)
            {
                //studentArray[i] = new MyStudentClass1(studen);

                studentList.Add(studentArray[i]);
                
            }
        }
        private void CreateObjects(StaffTBL s)
        {

        }

    }

}


