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
        private UserViewModel _currentUser;

        public MainViewModel()
        {
            Courses = new ObservableCollection<CourseViewModel>();
            LoadCourses();
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

        private void LoadCourses()
        {
            Course CPSC481 = new Course() { Name = "CPSC 481" };
            CPSC481.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Lorem ipsum",Content="The brown fox",Posted=System.DateTime.Now }, new Announcement() { Title = "Dolor sit amet",Content="jumps over",Posted=System.DateTime.Now }, new Announcement() { Title = "Hello world",Content="the lazy dog" }, new Announcement() { Title = "Testing 1,2,3" } };
            CPSC481.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque",Content = "ullamco laboris nisi" }, new Thread() { Title = "Porta Ornare Venenatis",Content = "ut aliquip ex" }, new Thread() { Title = "Cras",Content="ea commodo consequat" } };
            CPSC481.Lectures = new ObservableCollection<Lecture> { new Lecture() { Title = "Ligula",Content = "ullamco Ligula" }, new Lecture() { Title="ipsum",Content = "Ultricies Amet Cras" }, new Lecture() { Title="Fringilla Fusce",Content = "Euismod Purus" }, new Lecture() { Title="Lecture4",Content = "Magna" }, new Lecture() { Title="Lecture5",Content = "Vulputate Pharetra" } };
            CPSC481.Assignments = new ObservableCollection<Assignment> { new Assignment() {Title="One",Content = "Parturient Ipsum",Due=System.DateTime.Now }, new Assignment() { Title="Two",Content = "Fringilla" }, new Assignment() { Title="Three",Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Title="Four",Content = "Fusce Ligula" }, new Assignment() { Title="Five",Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(CPSC481));

            Course CPSC457 = new Course() { Name = "CPSC 457" };
            CPSC457.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Test ipsum" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Dolor" }, new Announcement() { Title = "Test" } };
            CPSC457.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque",Content="Content here" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            CPSC457.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            CPSC457.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(CPSC457));

            Course SENG515 = new Course() { Name = "SENG 515" };
            SENG515.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "ipy ipsum" }, new Announcement() { Title = "Hey World" }, new Announcement() { Title = "Hello" }, new Announcement() { Title = "Testing" } };
            SENG515.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque",Content="words." }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            SENG515.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            SENG515.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            Courses.Add(new CourseViewModel(SENG515));
        }
    }
}
