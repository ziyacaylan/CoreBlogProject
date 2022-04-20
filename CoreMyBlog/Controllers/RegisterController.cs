using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreMyBlog.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMyBlog.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        WriterCity cities=new WriterCity();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cities = cities.GetCityList();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer, string passwordAgain)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult result = writerValidator.Validate(writer);

            var writerMailCheck = wm.TGetByFilter(x => x.WriterMail == writer.WriterMail);
            
            

            if (ModelState.IsValid && writer.WriterPassword == passwordAgain && writerMailCheck == null)
            {
                writer.WriterAbout = "Deneme Test";
                writer.WriterStatus = true;
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else if (writer.WriterPassword != passwordAgain)
            {
                ModelState.AddModelError("WriterPassword", "Girdiğiniz Şifreler Eşleşmedi Lütfen Tekrar Deneyin");
            }
            else if (writerMailCheck != null)
            {
                ModelState.AddModelError("ErrorMessage", "Girdiğiniz E-Mail Adresini Kullanan Bir Hesap Mevcut");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            ViewBag.Cities = cities.GetCityList(); // geri gönderdiğimizde hata vermiyor...!
            return View(writer);
        }       
    }
}
