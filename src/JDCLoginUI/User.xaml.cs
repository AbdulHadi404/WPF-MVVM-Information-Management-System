using JDCLoginUI.ListViewModels;
using JDCLoginUI.ViewModels;
using JDCLoginUI.BackUp;
using JDCLoginUI.Views;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
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

namespace JDCLoginUI
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>

    public partial class User : MetroWindow
    {
        public User()
        {
            InitializeComponent();
        }

        private void Item_AddDonor_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donor_View_Model();
        }

        private void Item_AddDonation_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donation_View_Model();
        }

        private void Item_DonorList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donor_ListView_Model();
        }

        private void Item_DonationList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donation_ListView_Model();
        }

        private void Item_AddApplication_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Application_View_Model();
        }

        private void Item_AddStudent_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Student_View_Model();
        }

        private void Item_ApplicationList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Application_ListView_Model();
        }

        private void Item_StudentList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Student_ListView_Model();
        }

        private void Item_AddGuardian_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Guardian_View_Model();
        }

        private void Item_GuardianList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Guardian_ListView_Model();
        }

        private void Item_AddCourseEnrollment_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseEnrollment_View_Model();
        }

        private void Item_CourseEnrollmentList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseEnrollment_ListView_Model();
        }

        private void Item_Export_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Export_View_Model();
        }
    }
}
