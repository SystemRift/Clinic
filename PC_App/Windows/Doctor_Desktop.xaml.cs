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
    /// Логика взаимодействия для Doctor_Desktop.xaml
    /// </summary>
    public partial class Doctor_Desktop : Window
    {
        public Doctor_Desktop()
        {
            InitializeComponent();
            startclock();
        }

        private void startclock()
        {
            //throw new NotImplementedException();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            RlTime.Text = DateTime.Now.ToString(@"hh\:mm\:ss");
        }

        private void Btn_PList(object sender, RoutedEventArgs e)
        {

        }
    }
}
