using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.Utilities
{
    public class DataGenerator
    {
        private static Ipsum ipsum = new Ipsum();
        private static Random rnd = new Random();

        #region Announcements
        private static List<Announcement> _announcements;
        public static List<Announcement> Announcements
        {
            get { if (_announcements == null) GenerateAnnouncements(); return _announcements; }
        }
        private static void GenerateAnnouncements()
        {
            _announcements = new List<Announcement>();
            for (int i = 0; i < 100; i++)
            {
                _announcements.Add(new Announcement() {
                    Title = ipsum.GetWords(4),
                    Content = ipsum.GetWords(100),
                    Posted = GetRandomDateTime()
                });
            }
        }
        #endregion

        #region Assignments
        private static List<Assignment> _assignments;
        public static List<Assignment> Assignments
        {
            get { if (_assignments == null) GenerateAssignments(); return _assignments; }
        }
        private static void GenerateAssignments()
        {
            _assignments = new List<Assignment>();
            for (int i = 0; i < 100; i++)
            {
                _assignments.Add(new Assignment()
                {
                    Title = ipsum.GetWords(4),
                    Content = ipsum.GetWords(100),
                    Due = GetRandomDateTime()
                });
            }
        }
        #endregion

        #region Courses
        private static List<Course> _courses;
        public static List<Course> Courses
        {
            get { if (_courses == null) GenerateCourses(); return _courses; }
        }
        private static void GenerateCourses()
        {
            _courses = new List<Course>();
            for (int i = 0; i < 10; i++)
            {
                _courses.Add(new Course()
                {
                    Name = ipsum.GetWords(2),
                    Announcements = new ObservableCollection<Announcement>(Announcements.OrderBy(a => rnd.Next()).Take(rnd.Next(5, 20))),
                    Assignments = new ObservableCollection<Assignment>(Assignments.OrderBy(a => rnd.Next()).Take(rnd.Next(5, 20))),
                    Lectures = new ObservableCollection<Lecture>(Lectures.OrderBy(a => rnd.Next()).Take(rnd.Next(5, 20))),
                    Threads = new ObservableCollection<Thread>(Threads.OrderBy(a => rnd.Next()).Take(rnd.Next(5, 20)))
                });
            }
        }
        #endregion

        #region Lectures
        private static List<Lecture> _lectures;
        public static List<Lecture> Lectures
        {
            get { if (_lectures == null) GenerateLectures(); return _lectures; }
        }
        private static void GenerateLectures()
        {
            _lectures = new List<Lecture>();
            for (int i = 0; i < 100; i++)
            {
                _lectures.Add(new Lecture()
                {
                    Title = ipsum.GetWords(4),
                    Content = ipsum.GetWords(100),
                    Posted = GetRandomDateTime()
                });
            }
        }
        #endregion

        #region Posts
        private static List<Post> _posts;
        public static List<Post> Posts
        {
            get { if (_posts == null) GeneratePosts(); return _posts; }
        }
        private static void GeneratePosts()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 100; i++)
            {
                _posts.Add(new Post()
                {
                    Content = ipsum.GetWords(100),
                    Posted = GetRandomDateTime(),
                    Poster = Users[rnd.Next(Users.Count)]
                });
            }
        }
        #endregion

        #region Threads
        private static List<Thread> _threads;
        public static List<Thread> Threads
        {
            get { if (_threads == null) GenerateThreads(); return _threads; }
        }
        private static void GenerateThreads()
        {
            _threads = new List<Thread>();
            for (int i = 0; i < 100; i++)
            {
                _threads.Add(new Thread()
                {
                    Title = ipsum.GetWords(4),
                    Content = ipsum.GetWords(100),
                    Posted = GetRandomDateTime(),
                    Posts = new ObservableCollection<Post>(Posts.OrderBy(a => rnd.Next()).Take(rnd.Next(5, 20))),
                    Poster = Users[rnd.Next(Users.Count)]
                });
            }
        }
        #endregion

        #region Users
        private static List<User> _users;
        public static List<User> Users
        {
            get { if (_users == null) GenerateUsers(); return _users; }
        }
        private static void GenerateUsers()
        {
            _users = new List<User>();
            for (int i = 0; i < 100; i++)
            {
                _users.Add(new User()
                {
                    Username = ipsum.GetWords(1)
                });
            }
        }
        #endregion

        private static DateTime GetRandomDateTime()
        {
            DateTime start = new DateTime(2012, 1, 1);
            int range = (DateTime.Now - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
