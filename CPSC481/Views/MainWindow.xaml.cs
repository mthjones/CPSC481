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
        private MainViewModel _viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _viewModel;
        }

        private void PrimaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((string)PrimaryCategoryList.SelectedItem)
            {
                case "Announcements":
                    SecondaryCategoryList.ItemsSource = this._viewModel.Course.Announcements.Select(x => x.Title);
                    break;
                case "Forums":
                    SecondaryCategoryList.ItemsSource = this._viewModel.Course.Threads.Select(x => x.Title);
                    break;
                case "Assignments":
                    SecondaryCategoryList.ItemsSource = this._viewModel.Course.Assignments.Select(x => x.Content);
                    break;
                case "Lectures":
                    SecondaryCategoryList.ItemsSource = this._viewModel.Course.Lectures.Select(x => x.Content);
                    break;
                default:
                    break;
            }
        }

        private void SecondaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
