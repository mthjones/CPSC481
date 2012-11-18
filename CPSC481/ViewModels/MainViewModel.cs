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
            LoadCourses();
            SelectedCourse = Courses[0];
        }

        public ObservableCollection<CourseViewModel> Courses { get; set; }
        public CourseViewModel SelectedCourse
        {
            get { return this._selectedCourse; }
            set { this._selectedCourse = value; NotifyPropertyChanged("SelectedCourse"); }
        }

        private void LoadCourses()
        {
            Course CPSC481 = new Course() { Name = "CPSC 481" };
            CPSC481.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
            CPSC481.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            CPSC481.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            CPSC481.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(CPSC481));

            Course CPSC457 = new Course() { Name = "CPSC 457" };
            CPSC457.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Test ipsum" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Dolor" }, new Announcement() { Title = "Test" } };
            CPSC457.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            CPSC457.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            CPSC457.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(CPSC457));

            Course SENG515 = new Course() { Name = "SENG 515" };
            SENG515.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "ipy ipsum" }, new Announcement() { Title = "Hey World" }, new Announcement() { Title = "Hello" }, new Announcement() { Title = "Testing" } };
            SENG515.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            SENG515.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            SENG515.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(SENG515));
        }
    }
}
