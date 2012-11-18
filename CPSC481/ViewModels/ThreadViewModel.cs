using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class ThreadViewModel : ViewModelBase
    {
        //private ObservableCollection<PostViewModel> _posts = new ObservableCollection<PostViewModel>();
        public Thread Thread { get; set; }

        public ThreadViewModel()
        {
            Thread = new Thread() { Content = "Hello world!" };
        }

        public string Content
        {
            get { return Thread.Content; }
            set { NotifyPropertyChanged("Content"); Thread.Content = value; }
        }
    }
}
