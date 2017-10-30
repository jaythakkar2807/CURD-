using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationApplicationEntity;
using RegistrationApplicationRepos.User;
using RegistrationApplication.Models;

namespace RegistrationApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            //Console.Write("Index");
            try
            {
                String Name = collection["Name"];
                String Location = collection["Location"];

                UserData d = new UserData();
                d.addempl(Name, Location);
                ViewBag.message = "Registration Successfully";
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return View();
        }

        public ActionResult ViewRecords()
        {
            UserData user = new UserData();
            ClassViewModel model = new ClassViewModel();
            model.listUser = user.getUser();
            
                return View(model);
            
            
        }

        public ActionResult DeleteRecord(int id)
        {
            UserData user = new UserData();
            user.deleterecord(id);

            TempData["Success"] = "Delete Successfully!";
            return RedirectToAction("/ViewRecords");
        }

        public ActionResult EditDetail(int id)
        {
            UserData user = new UserData();
            ClassViewModel model = new ClassViewModel();

            model.userById = user.getUserDetailById(id);

            return View(model);
        }

        public ActionResult UpdateRecord(int id, FormCollection collection)
        {
            String Name = collection["Name"];
            String Location = collection["Location"];

            UserData user = new UserData();
            user.UpdateRecord(id, Name, Location);

            TempData["Success"] = "Update Successfully!";

            return RedirectToAction("/viewRecords");
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