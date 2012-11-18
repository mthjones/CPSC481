using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class AnnouncementViewModel : ViewModelBase
    {
        private Announcement _announcement;
        public Announcement Announcement
        {
            get { return this._announcement; }
            set { NotifyPropertyChanged("Announcement"); this._announcement = value; }
        }

        public AnnouncementViewModel()
        {
            this.Announcement = new Announcement() { Title = "Announcement", Content = "Placeholder", Posted = DateTime.Now };
        }

        public AnnouncementViewModel(Announcement announcement)
        {
            this.Announcement = announcement;
        }

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
    }
}
