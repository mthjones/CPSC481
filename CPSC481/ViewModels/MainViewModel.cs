using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IEnumerable<string> _secondaryCategories;
        private IEnumerable<string> _primaryCategories;
        private Course _course;

        public MainViewModel()
        {
            PrimaryCategories = new List<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            SecondaryCategories = new List<string> { };
            Course = new Course { Name = "CPSC 481" };
            Course.Announcements = new List<Announcement> { new Announcement() { Content="Lorem ipsum" }, new Announcement() { Content="Dolor sit amet" }, new Announcement() { Content="Hello world" }, new Announcement() { Content="Testing 1,2,3" } };
            Course.Threads = new List<Thread> { new Thread() { Content = "Nullam Pellentesque" }, new Thread() { Content = "Porta Ornare Venenatis" }, new Thread() { Content = "Cras" } };
            Course.Lectures = new List<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            Course.Assignments = new List<Assignment> { new Assignment() { Content="Parturient Ipsum" }, new Assignment() { Content="Fringilla" }, new Assignment() { Content="Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content="Fusce Ligula" }, new Assignment() { Content="Etiam Ullamcorper" } };
        }

        public Course Course
        {
            get { return this._course; }
            set { NotifyPropertyChanged("Course"); this._course = value; }
        }
        public IEnumerable<string> PrimaryCategories
        {
            get { return this._primaryCategories; }
            set { NotifyPropertyChanged("PrimaryCategories"); this._primaryCategories = value; }
        }
        public IEnumerable<string> SecondaryCategories
        {
            get { return this._secondaryCategories; }
            set { NotifyPropertyChanged("SecondaryCategories"); this._secondaryCategories = value; }
        }

        public void LoadSecondaryCategories(string primaryCategory)
        {
            switch (primaryCategory)
            {
                case "Announcements":
                    SecondaryCategories = this.Course.Announcements.Select(x=>x.Content);
                    break;
                case "Forums":
                    SecondaryCategories = this.Course.Threads.Select(x=>x.Title);
                    break;
                case "Assignments":
                    SecondaryCategories = this.Course.Assignments.Select(x=>x.Content);
                    break;
                case "Lectures":
                    SecondaryCategories = this.Course.Lectures.Select(x=>x.Content);
                    break;
                default:
                    break;
            }
        }
    }
}
