using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class PostViewModel : ViewModelBase
    {
        public PostViewModel()
            : this(new Post() { Content="Placeholder", Posted=DateTime.Now })
        {
        }

        public PostViewModel(Post post)
        {
            this.Post = post;
        }

        private Post Post { get; set; }
        public string Content
        {
            get { return Post.Content; }
            set { Post.Content = value; NotifyPropertyChanged("Content"); }
        }

        public User Poster
        {
            get { return Post.Poster; }
            set { Post.Poster = value; NotifyPropertyChanged("Poster"); }
        }

        public DateTime Posted
        {
            get { return Post.Posted; }
            set { Post.Posted = value; NotifyPropertyChanged("Posted"); }
        }
    }
}
