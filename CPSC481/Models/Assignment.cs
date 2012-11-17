using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.Models
{
    public class Assignment
    {
        public Course Course { get; private set; }
        public string Content { get; set; }
        public DateTime Due { get; set; }
    }
}
