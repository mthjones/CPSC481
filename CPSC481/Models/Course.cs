using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.Models
{
    public class Course
    {
        public string Name { get; set; }
        public ObservableCollection<Announcement> Announcements { get; set; }
        public ObservableCollection<Thread> Threads { get; set; }
        public ObservableCollection<Lecture> Lectures { get; set; }
        public ObservableCollection<Assignment> Assignments { get; set; }
    }
}
