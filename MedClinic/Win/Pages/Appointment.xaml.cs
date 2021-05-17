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

namespace MedClinic.Win.Pages
{
    /// <summary>
    /// Логика взаимодействия для Appointment.xaml
    /// </summary>
    public partial class Appointment : Page
    {
        public Appointment()
        {
            InitializeComponent();

            LastName_TB.Text = "Enter Last name here";
            LastName_TB.Foreground = Brushes.Gray;
            LastName_TB.FontSize = 20;

            FirstName_TB.Text = "Enter Firts name here";
            FirstName_TB.Foreground = Brushes.Gray;
            FirstName_TB.FontSize = 20;

            MiddleName_TB.Text = "Enter Middle name here";
            MiddleName_TB.Foreground = Brushes.Gray;
            MiddleName_TB.FontSize = 20;

            Pass_TB.Text = "Enter Passport ID here";
            Pass_TB.Foreground = Brushes.Gray;
            Pass_TB.FontSize = 20;

            Address_TB.Text = "Enter Address here";
            Address_TB.Foreground = Brushes.Gray;
            Address_TB.FontSize = 20;

            TelNum_TB.Text = "Enter Phone here";
            TelNum_TB.Foreground = Brushes.Gray;
            TelNum_TB.FontSize = 20;

            Email_TB.Text = "Enter Email here";
            Email_TB.Foreground = Brushes.Gray;
            Email_TB.FontSize = 20;


        }
        //Last Name
        private void LastName_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if(LastName_TB.Text == "Enter Last name here")
            {
                LastName_TB.Text = "";
            }
            
        }
        private void LastName_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LastName_TB.Text == "")
            {
                LastName_TB.Text = "Enter Last name here";
            }
        }
        //First Name
        private void FirstName_TB_GotFocus(object sender, RoutedEventArgs e) 
        {
            if (FirstName_TB.Text == "Enter Firts name here")
            {
                FirstName_TB.Text = "";
            }
        }
        private void FirstName_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FirstName_TB.Text == "")
            {
                FirstName_TB.Text = "Enter Firts name here";
            }
        }
        //Middle Name
        private void MiddleName_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MiddleName_TB.Text == "Enter Middle name here")
            {
                MiddleName_TB.Text = "";
            }
        }
        private void MiddleName_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (MiddleName_TB.Text == "")
            {
                MiddleName_TB.Text = "Enter Middle name here";
            }
        }
        //Passport  
        private void Pass_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_TB.Text == "Enter Passport ID here")
            {
                Pass_TB.Text = "";
            }
        }
        private void Pass_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_TB.Text == "")
            {
                Pass_TB.Text = "Enter Passport ID here";
            }
        }
        //Address 
        private void Address_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Address_TB.Text == "Enter Address here")
            {
                Address_TB.Text = "";
            }
        }
        private void Address_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Address_TB.Text == "")
            {
                Address_TB.Text = "Enter Address here";
            }
        }
        //TelNum
        private void TelNum_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TelNum_TB.Text == "Enter Phone here")
            {
                TelNum_TB.Text = "";
            }
        }
        private void TelNum_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TelNum_TB.Text == "")
            {
                TelNum_TB.Text = "Enter Phone here";
            }
        }
        //TelNum
        private void Email_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Email_TB.Text == "Enter Email here")
            {
                Email_TB.Text = "";
            }
        }
        private void Email_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email_TB.Text == "")
            {
                Email_TB.Text = "Enter Email here";
            }
        }


        //***** SAVE BUTTON (Diactivated becauese of Database rn)



        //private void BtnSave_Click(object sender, RoutedEventArgs e)
        //{
        //    if (IdPatient == 0)
        //    {
        //        if (LastName_TB is null)
        //        {
        //            MessageBox.Show("Введите фамилию", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
        //            return;
        //        }

        //        if (FirstName_TB is null)
        //        {
        //            MessageBox.Show("Введите имя", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
        //            return;
        //        }

        //        if (DPBirthDate is null)
        //        {
        //            MessageBox.Show("Введите дату рождения", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
        //            return;
        //        }

        //        if (TelNum_TB is null)
        //        {
        //            MessageBox.Show("Введите телефон", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
        //            return;
        //        }

        //        contex.Patient.Add(new Client()
        //        {
        //            LastName = LastName_TB.Text,
        //            FirstName = FirstName_TB.Text,
        //            Patronymic = MiddleName_TB.Text,
        //            Email = Email_TB.Text,
        //            Phone = TelNum_TB.Text,
        //            Birthday = DPBirthDate.SelectedDate,
        //            RegistrationDate = DateTime.Now.Date,
        //        });
        //        contex.SaveChanges();
        //        MessageBox.Show("Пользователь успешно добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        //        MainWindow main = new MainWindow();
        //        main.Show();
        //        this.Close();
        //    }
        //    else
        //    {

        //        var client = contex.Client.Where(i => i.ID == IdPatient).FirstOrDefault() as Patient;
        //        Patient.LastName = LastName_TB.Text;
        //        Patient.FirstName = FirstName_TB.Text;
        //        Patient.Patronymic = MiddleName_TB.Text;
        //        Patient.Email = Email_TB.Text;
        //        Patient.Phone = TelNum_TB.Text;
        //        Patient.Birthday = DPBirthDate.SelectedDate;
        //        contex.SaveChanges();
        //        MessageBox.Show("Всё успешно сохранено", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        //        MainWindow main = new MainWindow();
        //        main.Show();
        //        this.Close();
        //    }
        //}
    }

}
