using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        #region Fields
        private ViewModelBase _currentView;
        private string _selectedCategory;
        private ViewModelBase _selectedItem;
        #endregion

        #region Constructors
        public CourseViewModel()
            : this(new Course() { Name = "CPSC 481" })
        {
        }

        public CourseViewModel(Course course)
        {
            this.Course = course;
            this.Announcements = new ObservableCollection<AnnouncementViewModel>();
            this.Threads = new ObservableCollection<ThreadViewModel>();
            this.Lectures = new ObservableCollection<LectureViewModel>();
            this.Assignments = new ObservableCollection<AssignmentViewModel>();
            LoadCollections();

            this.Categories = new ObservableCollection<string> { "Announcements", "Forums", "Lectures", "Assignments" };
            this.Items = new ObservableCollection<ViewModelBase>();
            this.SelectedCategory = this.Categories[0];
        }
        #endregion

        #region Properties
        private Course Course { get; set; }
        public string Name
        {
            get { return Course.Name; }
            set { Course.Name = value; NotifyPropertyChanged("Name"); }
        }
        public ObservableCollection<AnnouncementViewModel> Announcements { get; set; }
        public ObservableCollection<ThreadViewModel> Threads { get; set; }
        public ObservableCollection<LectureViewModel> Lectures { get; set; }
        public ObservableCollection<AssignmentViewModel> Assignments { get; set; }
        public ObservableCollection<string> Categories { get; set; }
        public ObservableCollection<ViewModelBase> Items { get; set; }
        public ViewModelBase CurrentView
        {
            get { return this._currentView; }
            set { this._currentView = value; NotifyPropertyChanged("CurrentView"); }
        }
        public string SelectedCategory
        {
            get { return this._selectedCategory; }
            set { this._selectedCategory = value; LoadItems(); NotifyPropertyChanged("SelectedCategory"); }
        }
        public ViewModelBase SelectedItem
        {
            get { return this._selectedItem; }
            set { this._selectedItem = value; NotifyPropertyChanged("SelectedItem"); }
        }
        #endregion

        #region Private Methods
        private void LoadItems()
        {
            Items.Clear();
            switch (SelectedCategory)
            {
                case "Announcements":
                    Announcements.ToList().ForEach(Items.Add);
                    break;
                case "Forums":
                    Threads.ToList().ForEach(Items.Add);
                    break;
                case "Lectures":
                    Lectures.ToList().ForEach(Items.Add);
                    break;
                case "Assignments":
                    Assignments.ToList().ForEach(Items.Add);
                    break;
                default:
                    break;
            }
            SelectedItem = Items[0];
        }

        private void LoadCollections()
        {
            Course.Announcements = new ObservableCollection<Announcement> { new Announcement() { Title = "Lorem ipsum" }, new Announcement() { Title = "Dolor sit amet" }, new Announcement() { Title = "Hello world" }, new Announcement() { Title = "Testing 1,2,3" } };
            Course.Threads = new ObservableCollection<Thread> { new Thread() { Title = "Nullam Pellentesque" }, new Thread() { Title = "Porta Ornare Venenatis" }, new Thread() { Title = "Cras" } };
            Course.Lectures = new ObservableCollection<Lecture> { new Lecture() { Content = "Ligula" }, new Lecture() { Content = "Ultricies Amet Cras" }, new Lecture() { Content = "Euismod Purus" }, new Lecture() { Content = "Magna" }, new Lecture() { Content = "Vulputate Pharetra" } };
            Course.Assignments = new ObservableCollection<Assignment> { new Assignment() { Content = "Parturient Ipsum" }, new Assignment() { Content = "Fringilla" }, new Assignment() { Content = "Fermentum Ultricies Fringilla Adipiscing" }, new Assignment() { Content = "Fusce Ligula" }, new Assignment() { Content = "Etiam Ullamcorper" } };

            foreach (var announcement in Course.Announcements)
                Announcements.Add(new AnnouncementViewModel(announcement));
            foreach (var thread in Course.Threads)
                Threads.Add(new ThreadViewModel(thread));
            foreach (var lecture in Course.Lectures)
                Lectures.Add(new LectureViewModel(lecture));
            foreach (var assignment in Course.Assignments)
                Assignments.Add(new AssignmentViewModel(assignment));
        }
        #endregion
    }
}
