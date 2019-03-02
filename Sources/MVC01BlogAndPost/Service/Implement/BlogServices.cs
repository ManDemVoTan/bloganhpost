using MVC01BlogAndPost.Databases;
using MVC01BlogAndPost.Entities;
using MVC01BlogAndPost.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC01BlogAndPost.Service.Implement
{
    public class BlogServices : IBlogServices
    {
        public bool AddNew(Blog data)
        {
            try
            {
                DatabaseContextBlogAnhPost context = new DatabaseContextBlogAnhPost();
                context.Blogs.Add(data);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Blog> GetLists()
        {
            DatabaseContextBlogAnhPost context = new DatabaseContextBlogAnhPost();
            return context.Blogs.ToList();
        }
    }
}