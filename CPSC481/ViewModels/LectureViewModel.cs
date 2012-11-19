using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class LectureViewModel : ViewModelBase
    {
        public LectureViewModel()
            : this(new Lecture() { Title="Lorem ipsum", Content="Placeholder", Posted=DateTime.Now })
        {
        }

        public LectureViewModel(Lecture lecture)
        {
            this.Lecture = lecture;
        }

        private Lecture Lecture { get; set; }

        public string Title
        {
            get { return Lecture.Title; }
            set { Lecture.Title = value; NotifyPropertyChanged("Title"); }
        }
        public string Content
        {
            get { return Lecture.Content; }
            set { Lecture.Content = value; NotifyPropertyChanged("Content"); }
        }
        public DateTime Posted
        {
            get { return Lecture.Posted; }
            set { Lecture.Posted = value; NotifyPropertyChanged("Posted"); }
        }
    }
}
