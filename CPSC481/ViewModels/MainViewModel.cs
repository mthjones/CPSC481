using CPSC481.Models;
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

        public MainViewModel()
        {
            Courses = new ObservableCollection<CourseViewModel>();
            Courses.Add(new CourseViewModel(new Course() { Name = "CPSC 481" }));
            Courses.Add(new CourseViewModel(new Course() { Name = "CPSC 457" }));
            Courses.Add(new CourseViewModel(new Course() { Name = "SENG 515" }));
            SelectedCourse = Courses[0];
        }

        public ObservableCollection<CourseViewModel> Courses { get; set; }
        public CourseViewModel SelectedCourse
        {
            get { return this._selectedCourse; }
            set { this._selectedCourse = value; NotifyPropertyChanged("SelectedCourse"); }
        }
    }
}
