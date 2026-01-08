using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Title = " Create Student";
            ViewBag.Hint = "Please fill all the requirements";
            return View(new StudentCreateVm());
        }
        [HttpPost]
        public ActionResult Create(StudentCreateVm model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Title = "Welcome to the Student Create Page";
                ViewBag.Hint = "There is a wrong data";
                return View(model);
            }
            TempData["Success"] = "Student saved successfully";
            return RedirectToAction(nameof(Success),model);
        }
        [HttpGet]
        public IActionResult Success(StudentCreateVm model)
        {
            ViewBag.PageTitle = "Student Created";
            return View(model);
        }

    }
}
