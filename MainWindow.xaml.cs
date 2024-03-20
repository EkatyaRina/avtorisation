using avtorisation;
using System;
using System.Windows;

namespace RegistrationApp
{
    class Employee
    {
        string password;
        string login;
        string fullName;
        string post;
        public Employee(string password, string login, string fullName, string post)
        {
            this.password = password;
            this.login = login;
            this.fullName = fullName;
            this.post = post;
        }
    }    
    /*class Persona
     {
         string fullName;
         string post;
         public Persona(string fullName, string post)
         {
             this.fullName = fullName;
             this.post = post;
         }*/
    /* class Programmer
     {
         string password = "123Cool";
         string login= "TheMostSuccsesfullProgrammerInTheWorld";
         string fullName = "Zubenko Nikolay Petrovich";
         string post = "";
     }
 }*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            Employee programmer = new Employee("TheMostSuccsesfullProgrammerInTheWorld","123Cool", "Zubenko Nikolay Petrovich", "ProgrammEngenier");
            Employee Cleaner = new Employee("TheQueenOfClean", "BestCleaner001","Vezde Lubov Sergeevna","Killer");

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                 if ((txtUsername.Text == "TheMostSuccsesfullProgrammerInTheWorld") && (txtPassword.Password == "123Cool"))
                 {
                     MessageBox.Show("Registration successful!");
                     Window1 window1 = new Window1();
                     window1.Show();
                     Close();
                 }

                 if ((txtUsername.Text == "TheQueenOfClean") && (txtPassword.Password == "BestCleaner001"))
                 {
                     MessageBox.Show("Registration successful!");
                    Window1 window1 = new Window1();
                    window1.Show();
                    Close();

                }
                 else
                 {
                     MessageBox.Show("Please enter both username and password.");
                 }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
            
            
            
        }
    }
}
