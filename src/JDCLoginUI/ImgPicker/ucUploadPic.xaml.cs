using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace JDCLoginUI.ImgPicker
{
    /// <summary>
    /// ucUploadPic.xaml 
    /// </summary>
    public partial class ucUploadPic : UserControl
    {
        public ucUploadPic()
        {
            InitializeComponent();
            this.DataContext = Capture;
        }
        public ObservableCollection<string> Capture = new ObservableCollection<string>();
        private void UpLoadCaptrue_Click(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog logoSelected = new OpenFileDialog();
            logoSelected.Filter = "图片|*.jpg;*.png;*.bmp;*.gif";
            if (logoSelected.ShowDialog() == true)
            {
                Capture.Add(logoSelected.FileName);
            }
        }

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReMoveCaptrue_Click(object sender, MouseButtonEventArgs e)
        {
            Capture.Remove(((Image)sender).DataContext.ToString());
        }
    }
}
