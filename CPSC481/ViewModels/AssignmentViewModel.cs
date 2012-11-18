using CPSC481.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.ViewModels
{
    public class AssignmentViewModel : ViewModelBase
    {
        public AssignmentViewModel(Assignment assignment)
        {
            this.Assignment = assignment;
        }

        public Assignment Assignment { get; set; }
    }
}
