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
        private string _selectedPrimaryCategory;
        private string _selectedSecondaryCategory;

        public MainViewModel()
        {
            PrimaryCategories = new ObservableCollection<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            SecondaryCategories = new ObservableCollection<string> { };
            Course = new Course { Name = "CPSC 481" };
            Course.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
            Course.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            Course.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            Course.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            SelectedPrimaryCategory = PrimaryCategories[0];
        }

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; NotifyPropertyChanged("Course"); }
        }
        public ObservableCollection<string> PrimaryCategories
        {
            get { return this._primaryCategories; }
            set { this._primaryCategories = value; }
        }
        public ObservableCollection<string> SecondaryCategories
        {
            get { return this._secondaryCategories; }
            set { this._secondaryCategories = value; }
        }
        public string SelectedPrimaryCategory
        {
            get { return this._selectedPrimaryCategory; }
            set { this._selectedPrimaryCategory = value; LoadSecondaryCategories(); NotifyPropertyChanged("SelectedPrimaryCategory"); }
        }
        public string SelectedSecondaryCategory
        {
            get { return this._selectedSecondaryCategory; }
            set { this._selectedSecondaryCategory = value; LoadContent(); NotifyPropertyChanged("SelectedSecondaryCategory"); }
        }

        private void LoadSecondaryCategories()
        {
            SecondaryCategories.Clear();
            switch (SelectedPrimaryCategory)
            {
                case "Announcements":
                    this.Course.Announcements.Select(x => x.Title).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Forums":
                    this.Course.Threads.Select(x => x.Title).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Assignments":
                    this.Course.Assignments.Select(x => x.Content).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Lectures":
                    this.Course.Lectures.Select(x => x.Content).ToList().ForEach(SecondaryCategories.Add);
                    break;
                default:
                    break;
            }
            SelectedSecondaryCategory = SecondaryCategories[0];
        }

        private void LoadContent()
        {

        }
    }
}
