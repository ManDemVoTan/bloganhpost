using MVC01BlogAndPost.Entities;
using MVC01BlogAndPost.Service.Interfaces;
using MVC01BlogAndPost.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01BlogAndPost.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogServices _blogservice;
        public HomeController(IBlogServices blogservice)
        {
            _blogservice = blogservice;
        }
        public ActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            model.ListBlogs = _blogservice.GetLists();


            if (model.ListBlogs.Count <= 0)
            {
                for (int i = 0; i < 10; ++i)
                {
                    _blogservice.AddNew(new Blog()
                    {
                        BlogId =i,
                        Title = "Title " + i,
                        Content = "Content " + i
                    });
                }
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}