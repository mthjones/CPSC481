using CPSC481.Models;
using CPSC481.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CPSC481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> CourseCategories = new List<string> { "Announcements", "Forums", "Lectures", "Assignments" };
        List<string> Announcements = new List<string> { "Lorem ipsum", "Dolor sit amet", "Hello world", "Testing 1,2,3" };
        List<Thread> Forums = new List<Thread> { new Thread() { Content = "Nullam Pellentesque" }, new Thread() { Content="Porta Ornare Venenatis" }, new Thread() { Content="Cras" }};
        List<string> Assignments = new List<string> { "Parturient Ipsum", "Fringilla", "Fermentum Ultricies Fringilla Adipiscing", "Fusce Ligula", "Etiam Ullamcorper" };
        List<string> Lectures = new List<string> { "Ligula", "Ultricies Amet Cras", "Euismod Purus", "Magna", "Vulputate Pharetra" };

        public MainWindow()
        {
            InitializeComponent();
            PrimaryCategoryList.ItemsSource = CourseCategories;
        }

        private void PrimaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((string)PrimaryCategoryList.SelectedItem)
            {
                case "Announcements":
                    SecondaryCategoryList.ItemsSource = Announcements;
                    break;
                case "Forums":
                    SecondaryCategoryList.ItemsSource = Forums;
                    break;
                case "Assignments":
                    SecondaryCategoryList.ItemsSource = Assignments;
                    break;
                case "Lectures":
                    SecondaryCategoryList.ItemsSource = Lectures;
                    break;
                default:
                    break;
            }
        }

        private void SecondaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)PrimaryCategoryList.SelectedItem == "Forums")
            {
                ThreadViewModel newTVM = new ThreadViewModel();
                newTVM.Thread = (Thread)SecondaryCategoryList.SelectedItem;
                ThreadView.DataContext = newTVM;
            }
        }
    }
}
