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
    /// Interaction logic for Receivers_View.xaml
    /// </summary>
    public partial class Receivers_View : MetroContentControl
    {
        public Receivers_View()
        {
            InitializeComponent();

            SeriesCollectionColumn = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Amount",
                    Values = new ChartValues<double> {20,40,60} //bind Amount Here Top10 Receivers
                }
            };

            SeriesCollectionColumn.Add(new ColumnSeries
            {
                Title="Visits",
                Values = new ChartValues<double> {11,56,42} //bind Visits Here Top10 Receivers
            });

            LabelsColumn = new[] { "Name1", "Name2", "Name3"}; // bind Names Here Top10 Receivers
            DataContext = this;

            SeriesCollectionColumnDonationsToCategories = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Donations Given According to Categories",
                    Values = new ChartValues<double> {20,40,60} //bind "How many donations given to others between the given time period by category" count course
                }
            };

            LabelsColumnDonationsToCategories = new[] { "Category1", "Category2", "Category3" }; // bind Categories here Here
            DataContext = this;

            SeriesCollectionTop10Categories = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Top 10 Donation Categories",
                    Values = new ChartValues<double> {20,40,60} //bind "Top 10 categories donated most? (count)" count course
                }
            };

            LabelsTop10Categories = new[] { "Category1", "Category2", "Category3" }; // bind Categories here Here
            DataContext = this;
        }

        public SeriesCollection SeriesCollectionRow { get; set; }
        public string[] LabelsRow { get; set; }
        public SeriesCollection SeriesCollectionColumnDonationsToCategories { get; set; }
        public string[] LabelsColumnDonationsToCategories { get; set; }
        public SeriesCollection SeriesCollectionColumn { get; set; }
        public string[] LabelsColumn { get; set; }
        public SeriesCollection SeriesCollectionTop10Categories { get; set; }
        public string[] LabelsTop10Categories { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}