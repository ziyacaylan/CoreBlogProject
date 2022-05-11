using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMyBlog.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            cm.ContactAdd(contact);
            return RedirectToAction("Index","Blog");
        }
    }
}
