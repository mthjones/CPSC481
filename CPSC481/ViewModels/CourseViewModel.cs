using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class Category
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public class CourseViewModel : ViewModelBase
    {
        #region Fields
        private ViewModelBase _currentView;
        private Category _selectedCategory;
        private ViewModelBase _selectedItem;
        #endregion

        #region Constructors
        public CourseViewModel()
            : this(new Course() { Name = "Placeholder" })
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

            this.Categories = new ObservableCollection<Category> { new Category() {Name="Announcements", Count=1}, new Category() {Name="Forums", Count=2}, new Category() {Name="Lectures", Count=7}, new Category() {Name="Assignments", Count=0} };
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
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<ViewModelBase> Items { get; set; }
        public ViewModelBase CurrentView
        {
            get { return this._currentView; }
            set { this._currentView = value; NotifyPropertyChanged("CurrentView"); }
        }
        public Category SelectedCategory
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
            switch (SelectedCategory.Name)
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
