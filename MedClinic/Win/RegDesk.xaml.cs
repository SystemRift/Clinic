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
using System.Windows.Shapes;

namespace MedClinic.Win
{
    /// <summary>
    /// Логика взаимодействия для RegDesk.xaml
    /// </summary>
    public partial class RegDesk : Window
    {

        public RegDesk()
        {
            InitializeComponent();
        }

        private void AppointBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Win.Pages.Appointment();
        }

        private void DoctorsBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Win.Pages.DocSchedule();
        }

        private void PatientBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Win.Pages.PatientList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
