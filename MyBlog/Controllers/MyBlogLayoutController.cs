﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class MyBlogLayoutController : Controller
    {
        // GET: MyBlogLayout
        public ActionResult Index()
        {
            return View();
        }
    }
}