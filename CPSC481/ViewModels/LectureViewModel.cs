using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class LectureViewModel : ViewModelBase
    {
        public LectureViewModel(Lecture lecture)
        {
            this.Lecture = lecture;
        }

        public LectureViewModel()
        {
            // TODO: Complete member initialization
        }

        public Lecture Lecture { get; set; }
    }
}
