using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class AssignmentViewModel : ViewModelBase
    {
        public AssignmentViewModel()
            : this(new Assignment() { Title="Lorem ipsum", Content="Placeholder", Due=DateTime.Today.AddDays(7) })
        {
        }

        public AssignmentViewModel(Assignment assignment)
        {
            this.Assignment = assignment;
        }

        private Assignment Assignment { get; set; }

        public string Title
        {
            get { return Assignment.Title; }
            set { Assignment.Title = value; NotifyPropertyChanged("Title"); }
        }
        public string Content
        {
            get { return Assignment.Content; }
            set { Assignment.Content = value; NotifyPropertyChanged("Content"); }
        }
        public DateTime Due
        {
            get { return Assignment.Due; }
            set { Assignment.Due = value; NotifyPropertyChanged("Due"); }
        }
    }
}
