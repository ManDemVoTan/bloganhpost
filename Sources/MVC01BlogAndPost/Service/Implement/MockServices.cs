using MVC01BlogAndPost.Entities;
using MVC01BlogAndPost.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01BlogAndPost.Service.Implement
{
    public class MockServices : IBlogServices
    {
        public static List<Blog> ListBlogs = new List<Blog>();

        public bool AddNew(Blog data)
        {
            ListBlogs.Add(data);
            return true;
        }

        public List<Blog> GetLists()
        {
            return ListBlogs;
        }
    }
}