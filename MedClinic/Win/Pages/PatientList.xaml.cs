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
    /// Логика взаимодействия для PatientList.xaml
    /// </summary>
    public partial class PatientList : Page
    {
        public PatientList()
        {
            InitializeComponent();
            //  Filter();

            /* countpages.Insert(0, "Все");
            countpages.Insert(1, "10");
            countpages.Insert(2, "50");
            countpages.Insert(3, "200");
            CmbCountPages.ItemsSource = countpages; */
        }
        /*private void Filter()
        {
            vwClientLists = context.VwClientList.ToList();

            vwClientLists = vwClientLists.Where(i => 
                            (i.FirstName.Contains(TxtFio.Text) ||
                            i.LastName.Contains(TxtFio.Text) ||
                            i.Patronymic.Contains(TxtFio.Text)) &&
                            i.Email.Contains(TxtEmail.Text) &&
                            i.Phone.Contains(TxtPhone.Text)).ToList();

            switch(CmbGender.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    vwClientLists = vwClientLists.Where(i =>
                    i.GenderCode.Contains("м")).ToList();
                    break;
                case 2:
                    vwClientLists = vwClientLists.Where(i =>
                    i.GenderCode.Contains("ж")).ToList();
                    break;
            }

            switch(CmbFilter.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    vwClientLists = vwClientLists.OrderBy(i=>i.FirstName).Distinct().ToList();
                    break;
                case 2:
                    vwClientLists = vwClientLists.OrderByDescending(i => i.FirstName).ToList();
                    break;
                case 3:
                    vwClientLists = vwClientLists.OrderBy(i => i.LastVisit).Distinct().ToList();
                    break;
                case 4:
                    vwClientLists = vwClientLists.OrderByDescending(i => i.LastVisit).ToList();
                    break;
                case 5:
                    vwClientLists = vwClientLists.OrderBy(i => i.CountVisit).Distinct().ToList();
                    break;
                case 6:
                    vwClientLists = vwClientLists.OrderByDescending(i => i.CountVisit).ToList();
                    break;
            }

            a = vwClientLists.Count;

            switch(CmbCountPages.SelectedIndex)
            {
                case 0:
                    numpage = 1;
                    countpage = 1;
                    NavPage.Visibility = Visibility.Hidden;
                    TxtCountPages.Text = countpage.ToString();
                    TxtCountClient.Text = a.ToString() + " из "
                        + a.ToString();
                    break;
                case 1:
                    
                    NavPage.Visibility = Visibility.Visible;
                    if (vwClientLists.Count % 10 == 0)
                    {
                        countpage = vwClientLists.Count / 10;
                        TxtCountPages.Text = countpage.ToString();
                        
                    }
                    else
                    {
                        countpage = (vwClientLists.Count / 10) + 1;
                        TxtCountPages.Text = countpage.ToString();
                    }
                    vwClientLists = vwClientLists.Skip((numpage - 1) * 10).Take(10).ToList();
                    TxtCountClient.Text = (((numpage - 1) * 10) + 1).ToString() 
                        + " - " + (numpage * 10).ToString() + " из "
                        + a.ToString();
                    break;
                case 2:
                    
                    NavPage.Visibility = Visibility.Visible;
                    if (vwClientLists.Count % 50 == 0)
                    {
                        countpage = vwClientLists.Count / 50;
                        TxtCountPages.Text = countpage.ToString();
                    }
                    else
                    {
                        countpage = (vwClientLists.Count / 50) + 1;
                        TxtCountPages.Text = countpage.ToString();
                    }
                    vwClientLists = vwClientLists.Skip((numpage - 1) * 50).Take(50).ToList();
                    TxtCountClient.Text = (((numpage - 1) * 50) + 1).ToString()
                        + " - " + (numpage * 50).ToString() + " из "
                        + a.ToString();

                    break;
                case 3:
                    NavPage.Visibility = Visibility.Visible;
                    if (vwClientLists.Count % 200 == 0)
                    {
                        countpage = vwClientLists.Count / 200;
                        TxtCountPages.Text = countpage.ToString();
                    }
                    else
                    {
                        countpage = (vwClientLists.Count / 200) + 1;
                        TxtCountPages.Text = countpage.ToString();
                    }
                    vwClientLists = vwClientLists.Skip((numpage - 1) * 200).Take(200).ToList();
                    TxtCountClient.Text = (((numpage - 1) * 200) + 1).ToString()
                        + " - " + (numpage * 200).ToString() + " из "
                        + a.ToString();
                    break;
            } 


            if (numpage == 1)
            {
                Btn1.Content = numpage;
                Btn2.Content = numpage + 1;
                Btn3.Content = numpage + 2;
                Btn1.Background = Brushes.Gray;
                Btn2.Background = Brushes.White;
                Btn3.Background = Brushes.White;
            }
            if (numpage != 1 && numpage != countpage)
            {
                Btn1.Content = numpage - 1;
                Btn2.Content = numpage;
                Btn3.Content = numpage + 1;
                Btn1.Background = Brushes.White;
                Btn2.Background = Brushes.Gray;
                Btn3.Background = Brushes.White;
            }
            if (numpage == countpage)
            {
                Btn1.Content = numpage - 2;
                Btn2.Content = numpage - 1;
                Btn3.Content = numpage;
                Btn1.Background = Brushes.White;
                Btn2.Background = Brushes.White;
                Btn3.Background = Brushes.Gray;
            }
            


            LvClientList.ItemsSource = vwClientLists;
        } */

        private void Pages(int a)
        {

        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Filter();
        }

        private void Cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //numpage = 1;
            // Filter();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //if (numpage > 1)
            //{
            //    numpage--;
            //}
            // Filter();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //if (numpage < countpage)
            //{
            //    numpage++;
            //}
            // Filter();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //numpage = Convert.ToInt32(Btn1.Content);
            //Filter();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            //numpage = Convert.ToInt32(Btn2.Content);
            // Filter();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            //numpage = Convert.ToInt32(Btn3.Content);
            // Filter();
        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            F_Email.Clear();
            F_Name.Clear();
            F_TelNum.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
