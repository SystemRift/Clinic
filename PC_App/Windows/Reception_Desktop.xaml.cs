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
using System.Windows.Threading;

namespace PC_App.Windows
{
    /// <summary>
    /// Логика взаимодействия для Desktop.xaml
    /// </summary>
    public partial class Reception_Desktop : Window
    {
        public Reception_Desktop()
        {
            InitializeComponent();
            startclock();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            RlTime.Text = DateTime.Now.ToString(@"hh\:mm\:ss");
        }

        private void Btn_TTable(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_PList(object sender, RoutedEventArgs e)
        {
            Main.Content = new Windows.Pages.PatientList();
        }

        private void Btn_SubP(object sender, RoutedEventArgs e)
        {

        }
    }
}
