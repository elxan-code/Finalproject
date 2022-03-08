﻿using Finalproject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;

        }


        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }
        public IActionResult Blogdetails(int? id)
        {

            return View(_context.Blogs.Find(id));

        }

    }
}
