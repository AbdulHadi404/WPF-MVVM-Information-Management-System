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
    /// Interaction logic for Users_View.xaml
    /// </summary>
    public partial class Users_View : MetroContentControl
    {
        public Users_View()
        {
            InitializeComponent();

            SeriesCollectionUsers = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Users",
                    Values = new ChartValues<double> { 100, 50, 39, 50, 55, 60 } //bind queris insted of these values for all reports
                }
            };

            LabelsUsers = new[] { "Total Users", "Active users", "Active users as ADMIN", "Active users as SUPER-ADMIN", "Active users as USER", "Deactivated Users" };
            Formatter = value => value + " Users";

            DataContext = this;
        }

        public SeriesCollection SeriesCollectionUsers { get; set; }
        public string[] LabelsUsers { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}