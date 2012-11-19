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

        public DateTime Posted
        {
            get { return Post.Posted; }
            set { Post.Posted = value; NotifyPropertyChanged("Posted"); }
        }
    }
}
