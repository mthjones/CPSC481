using CPSC481.Models;
using CPSC481.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private CourseViewModel _selectedCourse;
        private UserViewModel _currentUser;

        public MainViewModel()
        {
            Courses = new ObservableCollection<CourseViewModel>();
            GenerateData();
            SelectedCourse = Courses[0];
            CurrentUser = new UserViewModel(new User() { Username = "example@example.com" });
        }

        public ObservableCollection<CourseViewModel> Courses { get; set; }
        public CourseViewModel SelectedCourse
        {
            get { return this._selectedCourse; }
            set { this._selectedCourse = value; NotifyPropertyChanged("SelectedCourse"); }
        }
        public UserViewModel CurrentUser
        {
            get { return this._currentUser; }
            set { this._currentUser = value; NotifyPropertyChanged("CurrentUser"); }
        }

        private void GenerateData()
        {
            foreach (var course in DataGenerator.Courses)
            {
                Courses.Add(new CourseViewModel(course));
            }
        }
    }
}
