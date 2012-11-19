using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel()
            : this(new User() { Username = "testuser" })
        {
        }

        public UserViewModel(User user)
        {
            this.User = user;
        }

        private User User { get; set; }

        public string Username
        {
            get { return User.Username; }
            set { User.Username = value; NotifyPropertyChanged("Username"); }
        }
    }
}
