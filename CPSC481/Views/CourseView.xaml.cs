using CPSC481.ViewModels;
using System;
using System.Collections.Generic;
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

namespace CPSC481.Views
{
    /// <summary>
    /// Interaction logic for CourseView.xaml
    /// </summary>
    public partial class CourseView : UserControl
    {
        public CourseView()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CourseViewModel viewModel = (CourseViewModel)this.DataContext;
            switch (((Category)CategoryList.SelectedItem).Name)
            {
                case "Announcements":
                    viewModel.SelectedItem = new AnnouncementFormViewModel();
                    break;
                case "Forums":
                    viewModel.SelectedItem = new ThreadFormViewModel();
                    break;
                case "Lectures":
                    viewModel.SelectedItem = new LectureFormViewModel();
                    break;
                case "Assignments":
                    viewModel.SelectedItem = new AssignmentFormViewModel();
                    break;
                default:
                    break;
            }
        }
    }
}
