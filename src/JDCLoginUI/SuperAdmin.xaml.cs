using JDCLoginUI.ListViewModels;
using JDCLoginUI.ViewModels;
using JDCLoginUI.Views;
using JDCLoginUI.BackUp;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace JDCLoginUI
{
    /// <summary>
    /// Interaction logic for SuperAdmin.xaml
    /// </summary>
        
    public partial class SuperAdmin : MetroWindow
    {
        public SuperAdmin()
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

        private void Item_AddRecipient_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Recipient_View_Model();
        }

        private void Item_AddReceipt_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Receipt_View_Model();
        }

        private void Item_DonorList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donor_ListView_Model();
        }

        private void Item_AddApplication_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Application_View_Model();
        }

        private void Item_AddStudent_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Student_View_Model();
        }

        private void Item_DonationList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donation_ListView_Model();
        }

        private void Item_RecipientList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Recipient_ListView_Model();
        }

        private void Item_ReceiptList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Receipt_ListView_Model();
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

        private void Item_AddCourse_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Course_View_Model();
        }

        private void Item_AddCourseEnrollment_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseEnrollment_View_Model();
        }

        private void Item_CourseList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Course_ListView_Model();
        }

        private void Item_CourseEnrollmentList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseEnrollment_ListView_Model();
        }

        private void Item_AddDonationType_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationType_View_Model();
        }

        private void Item_AddDonationCategory_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationCategory_View_Model();
        }

        private void Item_DonationTypeList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationType_ListView_Model();
        }

        private void Item_DonationCategoryList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationCategory_ListView_Model();
        }

        private void Item_CourseCompletion_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseCompletion_View_Model();
        }

        private void Item_CourseStatus_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseStatus_View_Model();
        }

        private void Item_DonationTypeStatus_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationTypeStatus_View_Model();
        }

        private void Item_DonationCategoryStatus_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationCategoryStatus_View_Model();
        }

        private void Item_DonorListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donor_Log_ListView_Model();
        }

        private void Item_DonationListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donation_Log_ListView_Model();
        }

        private void Item_DonationTypeListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationType_Log_ListView_Model();
        }

        private void Item_DonationCategoryListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new DonationCategory_Log_ListView_Model();
        }

        private void Item_ReceiptListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Receipt_Log_ListView_Model();
        }

        private void Item_RecipientListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Recipient_Log_ListView_Model();
        }

        private void Item_ApplicationListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Application_Log_ListView_Model();
        }

        private void Item_StudentListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Student_Log_ListView_Model();
        }

        private void Item_GuardianListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Guardian_Log_ListView_Model();
        }

        private void Item_CourseListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Course_Log_ListView_Model();
        }

        private void Item_CourseEnrollmentListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseEnrollment_Log_ListView_Model();
        }

        private void Item_ApplicationReport_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Applications_View_Model();
        }

        private void Item_StudentReport_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Students_View_Model();
        }

        private void Item_UsersReport_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Users_View_Model();
        }

        private void Item_ReceiversReport_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Receivers_View_Model();
        }

        private void Item_DonationsReport_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Donors_View_Model();
        }

        private void Item_ApplicationTypeStatus_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Application_Status_View_Model();
        }

        private void Item_UsersListLog_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new User_Log_ListView_Model();
        }

        private void Item_UsersList_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Users_ListView_Model();
        }

        private void Item_UsersRole_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new UserRole_View_Model();
        }

        private void Item_UsersStatus_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new UserStatus_View_Model();
        }
        private void Item_Export_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Export_View_Model();
        }
        private void Item_Import_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new Import_View_Model();
        }
    }


    }
