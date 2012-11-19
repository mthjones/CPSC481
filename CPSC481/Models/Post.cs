using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.Models
{
    public class Post
    {
        public string Content { get; set; }
        public DateTime Posted { get; set; }
        public User Poster { get; set; }
    }
}
