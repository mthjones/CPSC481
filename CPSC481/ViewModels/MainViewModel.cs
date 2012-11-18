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
        private ObservableCollection<string> _secondaryCategories;
        private ObservableCollection<string> _primaryCategories;
        private Course _course;

        public MainViewModel()
        {
            PrimaryCategories = new ObservableCollection<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            SecondaryCategories = new ObservableCollection<string> { };
            Course = new Course { Name = "CPSC 481" };
            Course.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
            Course.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            Course.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            Course.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
        }

        public Course Course
        {
            get { return this._course; }
            set { NotifyPropertyChanged("Course"); this._course = value; }
        }
        public ObservableCollection<string> PrimaryCategories
        {
            get { return this._primaryCategories; }
            set { NotifyPropertyChanged("PrimaryCategories"); this._primaryCategories = value; }
        }
        public ObservableCollection<string> SecondaryCategories
        {
            get { return this._secondaryCategories; }
            set { NotifyPropertyChanged("SecondaryCategories"); this._secondaryCategories = value; }
        }
    }
}
