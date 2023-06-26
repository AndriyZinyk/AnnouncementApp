using Announcement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace WMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Main()
        {
            return View(AnnouncementDB.AnnouncementList);
        }

        public IActionResult ShowDetails(Guid Id)
        {
            var ann = AnnouncementDB.AnnouncementList.FirstOrDefault(a => a.Id == Id);
            return View("ShowDetails", ann);            
        }

        [HttpGet]
        public IActionResult Add(Guid Id)
        {
            var ann = new Announcement.Models.Announcement();
            return View("Add", ann);
        }

        [HttpPost]
        public IActionResult Add(Announcement.Models.Announcement announcement)
        {
            var ann = new Announcement.Models.Announcement();
            ann.Id = Guid.NewGuid();
            ann.Title = announcement.Title;
            ann.Description = announcement.Description;
            ann.AddDate = DateTime.Now;
            ann.EditDate = DateTime.Now;
            AnnouncementDB.AnnouncementList.Add(ann);
            return View("Main", AnnouncementDB.AnnouncementList);
        }

        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            var ann = AnnouncementDB.AnnouncementList.FirstOrDefault(a => a.Id == Id);
            return View("Delete", ann);
        }

        [HttpPost]
        public IActionResult Delete(Announcement.Models.Announcement announcement)
        {
            var ann = AnnouncementDB.AnnouncementList.FirstOrDefault(a => a.Id == announcement.Id);
            AnnouncementDB.AnnouncementList.Remove(ann);
            return View("Main", AnnouncementDB.AnnouncementList);
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            var ann = AnnouncementDB.AnnouncementList.FirstOrDefault(a => a.Id == Id);
            return View("Edit", ann);
        }

        [HttpPost]
        public IActionResult Edit(Announcement.Models.Announcement announcement)
        {
            var ann = AnnouncementDB.AnnouncementList.Find(a => a.Id == announcement.Id);
            ann.Title = announcement.Title;
            ann.Description = announcement.Description;
            ann.EditDate = DateTime.Now;
            return View("Main", AnnouncementDB.AnnouncementList);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}