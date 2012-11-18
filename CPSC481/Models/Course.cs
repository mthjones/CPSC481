using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.Models
{
    public class Course
    {
        public string Name { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Thread> Threads { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
