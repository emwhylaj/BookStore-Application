using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Book book = new()
            {
                Id = 1,
                Title = "Learning ASP.NET Core 2.0",
                Genre = "Programming & Software Developement",
                Price = 45,
                PublishDate = new DateTime(2012, 04, 23),
                Authors = new List<string> { "Jason De Oliveira", "Micheal Bruchet" }
            };
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}