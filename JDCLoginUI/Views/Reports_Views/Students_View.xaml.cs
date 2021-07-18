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
    /// Interaction logic for Students_View.xaml
    /// </summary>
    public partial class Students_View : MetroContentControl
    {
        public Students_View()
        {
            InitializeComponent();

            SeriesCollectionRow = new SeriesCollection
            {
                new RowSeries
                {
                    Values = new ChartValues<double> {10,50} //bind "Students Joinned Course", "Student Completed Course" query here
                }
            };

            LabelsRow = new[] { "Newcomers", "Alumni" };
            Formatter = value => value.ToString("#");

            DataContext = this;

            SeriesCollectionColumn = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Newcomers",
                    Values = new ChartValues<double> {20,40,60,22,55,77} //bind "Students Joinned Course" count course
                }
            };

            SeriesCollectionColumn.Add(new ColumnSeries
            {
                Title="Alumni",
                Values = new ChartValues<double> {11,56,42,24,67,94} //bind "Students Completed Course" count course
            });

            LabelsColumn = new[] { "Course 1", "Course2", "Course3", "Course4", "Course5", "Course6" }; // bind Courses Here
            Formatter = value => value + " Students";
            DataContext = this;

            SeriesCollectionColumnTop10 = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Top 10 Courses Joined by Studensts",
                    Values = new ChartValues<double> {20,40,60} //bind "Students Joinned Course" count course
                }
            };

            LabelsColumnTop10 = new[] { "Top10Course 1", "Top10Course2", "Top10Course3" }; // bind Courses Here
            Formatter = value => value + " Students";

            DataContext = this;
        }

        public SeriesCollection SeriesCollectionRow { get; set; }
        public string[] LabelsRow { get; set; }
        public SeriesCollection SeriesCollectionColumnTop10 { get; set; }
        public string[] LabelsColumnTop10 { get; set; }
        public SeriesCollection SeriesCollectionColumn { get; set; }
        public string[] LabelsColumn { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}