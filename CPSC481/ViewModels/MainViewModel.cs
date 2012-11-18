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
        private static readonly List<Announcement> _announcementsList = new List<Announcement> { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
        private static readonly List<Thread> _threadList = new List<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
        private static readonly List<Lecture> _lectureList = new List<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
        private static readonly List<Assignment> _assignmentList = new List<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };
        private Course _course;
        private string _selectedPrimaryCategory;
        private ViewModelBase _selectedSecondaryCategory;

        public MainViewModel()
        {
            PrimaryCategories = new ObservableCollection<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            SecondaryCategories = new ObservableCollection<ViewModelBase> { };
            Course = new Course { Name = "CPSC 481" };
            Announcements = new ObservableCollection<AnnouncementViewModel>();
            foreach (var announcement in _announcementsList)
            {
                Announcements.Add(new AnnouncementViewModel(announcement));
            }
            Threads = new ObservableCollection<ThreadViewModel>();
            foreach (var thread in _threadList)
            {
                Threads.Add(new ThreadViewModel(thread));
            }
            Lectures = new ObservableCollection<LectureViewModel>();
            foreach (var lecture in _lectureList)
            {
                Lectures.Add(new LectureViewModel(lecture));
            }
            Assignments = new ObservableCollection<AssignmentViewModel>();
            foreach (var assignment in _assignmentList)
            {
                Assignments.Add(new AssignmentViewModel(assignment));
            }
            SelectedPrimaryCategory = PrimaryCategories[0];
        }

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; NotifyPropertyChanged("Course"); }
        }
        public ObservableCollection<AnnouncementViewModel> Announcements { get; set; }
        public ObservableCollection<ThreadViewModel> Threads { get; set; }
        public ObservableCollection<LectureViewModel> Lectures { get; set; }
        public ObservableCollection<AssignmentViewModel> Assignments { get; set; }
        public ObservableCollection<string> PrimaryCategories { get; set; }
        public ObservableCollection<ViewModelBase> SecondaryCategories { get; set; }

        public string SelectedPrimaryCategory
        {
            get { return this._selectedPrimaryCategory; }
            set { this._selectedPrimaryCategory = value; LoadSecondaryCategories(); NotifyPropertyChanged("SelectedPrimaryCategory"); }
        }
        public ViewModelBase SelectedSecondaryCategory
        {
            get { return this._selectedSecondaryCategory; }
            set { this._selectedSecondaryCategory = value; NotifyPropertyChanged("SelectedSecondaryCategory"); }
        }

        private void LoadSecondaryCategories()
        {
            SecondaryCategories.Clear();
            switch (SelectedPrimaryCategory)
            {
                case "Announcements":
                    this.Announcements.ToList().ForEach(SecondaryCategories.Add);
                    break;
                case "Forums":
                    this.Threads.ToList().ForEach(SecondaryCategories.Add);;
                    break;
                case "Assignments":
                    this.Assignments.ToList().ForEach(SecondaryCategories.Add);;
                    break;
                case "Lectures":
                    this.Lectures.ToList().ForEach(SecondaryCategories.Add);;
                    break;
                default:
                    break;
            }
            SelectedSecondaryCategory = SecondaryCategories[0];
        }
    }
}
