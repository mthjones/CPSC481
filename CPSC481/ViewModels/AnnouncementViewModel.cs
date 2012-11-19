using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class AnnouncementViewModel : ViewModelBase
    {
        public AnnouncementViewModel()
            : this(new Announcement() { Title = "Announcement", Content = "Placeholder", Posted = DateTime.Now })
        {
        }

        public AnnouncementViewModel(Announcement announcement)
        {
            this.Announcement = announcement;
        }

        private Announcement Announcement { get; set; }

        public string Title
        {
            get { return Announcement.Title; }
            set { Announcement.Title = value; NotifyPropertyChanged("Title"); }
        }

        public string Content
        {
            get { return Announcement.Content; }
            set { Announcement.Content = value; NotifyPropertyChanged("Content"); }
        }

        public DateTime Posted
        {
            get { return Announcement.Posted; }
            set { Announcement.Posted = value; NotifyPropertyChanged("Posted"); }
        }
    }
}
