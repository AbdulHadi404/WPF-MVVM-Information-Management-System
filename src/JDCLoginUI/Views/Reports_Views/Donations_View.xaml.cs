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
using MahApps.Metro.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.ComponentModel;

namespace JDCLoginUI.Views
{
    /// <summary>
    /// Interaction logic for Donations_View.xaml
    /// </summary>
    public partial class Donations_View : MetroContentControl
    {
        public Donations_View()
        {
            InitializeComponent();

            SeriesCollectionColumn = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Male",
                    Values = new ChartValues<double> {20,40,60} //bind query 
                }
            };

            SeriesCollectionColumn.Add(new ColumnSeries
            {
                Title="Female",
                Values = new ChartValues<double> {11,56,42} //bind query 
            });

            LabelsColumn = new[] { "Name1", "Name2", "Name3"}; // bind Names Here 
            DataContext = this;

            SeriesCollectionColumnDonationsToCategoriesReceived = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Donations Received According to Categories",
                    Values = new ChartValues<double> {20,40,60} //bind "How many donations received by others between the given time period by category" count 
                }
            };

            LabelsColumnDonationsToCategoriesReceived = new[] { "Category1", "Category2", "Category3" }; // bind Categories here Here
            DataContext = this;

            SeriesCollectionCashDonations = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Donations Received as Cash",
                    Values = new ChartValues<double> {20,40,60} //bind query
                }
            };

            LabelsCashDonations = new[] { "User1", "User2", "User3" }; // bind here Here
            DataContext = this;

            SeriesCollectionFrequentVisitDonors = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Visits",
                    Values = new ChartValues<double> {20,40,60} //bind query
                }
            };

            LabelsFrequentVisitDonors = new[] { "Name1", "Name2", "Name3" }; // bind here Here
            DataContext = this;

            SeriesCollectionTopDonationDates = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Amount",
                    Values = new ChartValues<double> {20,40,60} //bind query
                }
            };

            LabelsTopDonationDates = new[] { "Date1", "Date2", "Date3" }; // bind here Here
            DataContext = this;
        }

        public SeriesCollection SeriesCollectionRow { get; set; }
        public string[] LabelsRow { get; set; }
        public SeriesCollection SeriesCollectionColumnDonationsToCategoriesReceived { get; set; }
        public string[] LabelsColumnDonationsToCategoriesReceived { get; set; }
        public SeriesCollection SeriesCollectionColumn { get; set; }
        public string[] LabelsColumn { get; set; }
        public SeriesCollection SeriesCollectionCashDonations { get; set; }
        public string[] LabelsCashDonations { get; set; }
        public SeriesCollection SeriesCollectionFrequentVisitDonors { get; set; }
        public string[] LabelsFrequentVisitDonors { get; set; }
        public SeriesCollection SeriesCollectionTopDonationDates { get; set; }
        public string[] LabelsTopDonationDates { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}