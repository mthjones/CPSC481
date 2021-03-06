﻿using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class ThreadViewModel : ViewModelBase
    {
        public ThreadViewModel()
            : this(new Thread() { Title="Lorem ipsum dolor", Content = "Hello world!" })
        {
        }

        public ThreadViewModel(Thread thread)
        {
            this.Thread = thread;
            this.Posts = new ObservableCollection<PostViewModel>();
            LoadCollections();
        }

        private Thread Thread { get; set; }

        public string Title
        {
            get { return Thread.Title; }
            set { Thread.Title = value; NotifyPropertyChanged("Title"); }
        }

        public string Content
        {
            get { return Thread.Content; }
            set { Thread.Content = value; NotifyPropertyChanged("Content"); }
        }

        public User Poster
        {
            get { return Thread.Poster; }
            set { Thread.Poster = value; NotifyPropertyChanged("Poster"); }
        }

        public DateTime Posted
        {
            get { return Thread.Posted; }
            set { Thread.Posted = value; NotifyPropertyChanged("Posted"); }
        }

        public ObservableCollection<PostViewModel> Posts { get; set; }

        private void LoadCollections()
        {
            foreach (var post in Thread.Posts)
                Posts.Add(new PostViewModel(post));
        }
    }
}
