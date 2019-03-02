using MVC01BlogAndPost.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC01BlogAndPost.Databases
{
    public class DatabaseContextBlogAnhPost : DbContext
    {
        public DatabaseContextBlogAnhPost() : base("DatabaseContext")
        {
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}