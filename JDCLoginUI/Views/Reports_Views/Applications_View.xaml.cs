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

namespace JDCLoginUI.Views
{
    /// <summary>
    /// Interaction logic for Applications_View.xaml
    /// </summary>
    public partial class Applications_View : MetroContentControl
    {
        public Applications_View()
        {
                InitializeComponent();

            SeriesCollectionReports = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Applications Report",
                    Values = new ChartValues<double> { 10, 50, 39, 50 } //bind queris insted of these values for all reports
                }
            };

                LabelsReports = new[] { "Applications Received", "Applications Approved", "Applications Rejected", "Approved But No Donations Received" };
            Formatter = value => value + " Reports";

            DataContext = this;

            SeriesCollectionApplications = new SeriesCollection
                {
                new ColumnSeries
                {
                    Title = "Approved But No Donations Received",
                    Values = new ChartValues<double> { 10, 50, 39, 50 } //bind count with applicant name insted of these values
                }
            };

            LabelsApplications = new[] { "ApplicationName1", "ApplicationName2", "ApplicationName3", "ApplicationName4" }; //bind course names here

            DataContext = this;
        }

        public SeriesCollection SeriesCollectionReports { get; set; }
        public SeriesCollection SeriesCollectionApplications { get; set; }
        public string[] LabelsReports { get; set; }
        public string[] LabelsApplications { get; set; }
        public Func<double, string> Formatter { get; set; }


    }
}
