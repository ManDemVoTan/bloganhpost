﻿using MVC01BlogAndPost.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01BlogAndPost.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Blog> ListBlogs { get; set; }
    }
}