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
            Announcement = new Announcement() { Title = "Announcement", Content = "Placeholder", Posted = DateTime.Now };
        }
    }
}
