﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC481.Models
{
    public class Thread
    {
        public Course Course { get; private set; }
        public List<Post> Posts { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Posted { get; set; }
        public User Poster { get; set; }
    }
}
