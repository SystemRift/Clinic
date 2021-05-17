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
using static MedClinic.SuppClass.Check;

namespace MedClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //entities entities = new entities();
        //Check check = new Check();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //    string b = check.SymCheck(log.Text);
            //    string g = check.SymCheck(pass.Password);
            //    if (b != "")
            //    {
            //        MessageBox.Show("логин");
            //        log.Focus();
            //        return;
            //    }

            //    if (g != "")
            //    {
            //        MessageBox.Show("пароль");
            //        pass.Focus();
            //        return;
            //    }

            //    var a = entities.Enter.ToList().Where(i => i.Login == log.Text && i.Pass == pass.Password).FirstOrDefault();

            //    if (a != null)
            //    {
            //        this.Hide();
            //        new Desktop().Show();
            //        this.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Пароль или Логин написаны неверно!");
            //        return;
            //    }

            this.Hide();
            new Win.RegDesk().Show();
            this.Close();
        }
    }
}
