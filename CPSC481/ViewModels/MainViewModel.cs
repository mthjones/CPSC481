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
        private ViewModelBase _currentView;

        public MainViewModel()
        {
            PrimaryCategories = new ObservableCollection<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            SecondaryCategories = new ObservableCollection<string> { };
            Course = new Course { Name = "CPSC 481" };
            Announcements = new ObservableCollection<Announcement>() { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
            Threads = new ObservableCollection<Thread>() { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            Lectures = new ObservableCollection<Lecture>() { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            Assignments = new ObservableCollection<Assignment>() { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
            SelectedPrimaryCategory = PrimaryCategories[0];
        }

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; NotifyPropertyChanged("Course"); }
        }
        public ObservableCollection<Announcement> Announcements { get; set; }
        public ObservableCollection<Thread> Threads { get; set; }
        public ObservableCollection<Lecture> Lectures { get; set; }
        public ObservableCollection<Assignment> Assignments { get; set; }
        public ObservableCollection<string> PrimaryCategories { get; set; }
        public ObservableCollection<string> SecondaryCategories { get; set; }

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
        public ViewModelBase CurrentView
        {
            get { return this._currentView; }
            set { this._currentView = value; NotifyPropertyChanged("CurrentView"); }
        }

        private void LoadSecondaryCategories()
        {
            SecondaryCategories.Clear();
            switch (SelectedPrimaryCategory)
            {
                case "Announcements":
                    this.Announcements.Select(x => x.Title).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Forums":
                    this.Threads.Select(x => x.Title).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Assignments":
                    this.Assignments.Select(x => x.Content).ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Lectures":
                    this.Lectures.Select(x => x.Content).ToList().ForEach(SecondaryCategories.Add);
                    break;
                default:
                    break;
            }
            SelectedSecondaryCategory = SecondaryCategories[0];
        }

        private void LoadContent()
        {
            switch (SelectedPrimaryCategory)
            {
                case "Announcements":
                    this.CurrentView = new AnnouncementViewModel();
                    break;
                case "Forums":
                    this.CurrentView = new ThreadViewModel();
                    break;
                case "Assignments":
                    this.CurrentView = new AssignmentViewModel();
                    break;
                case "Lectures":
                    this.CurrentView = new LectureViewModel();
                    break;
                default:
                    break;
            }
        }
    }
}
