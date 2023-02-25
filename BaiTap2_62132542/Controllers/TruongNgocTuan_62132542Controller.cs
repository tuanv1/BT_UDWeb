using BaiTap2_62132542.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_62132542.Controllers
{
    public class TruongNgocTuan_62132542Controller : Controller
    {
        // GET: TruongNgocTuan_62132542
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["ten"];
            ViewBag.Marks = field["Marks"];
            return View();
        }
        public ActionResult UseRequest(string field)
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["ten"];
            ViewBag.Marks = Request["Marks"];
            return View();
        }

        public ActionResult UseAction(string Id, string Name, string Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;
            return View();
        }

        public ActionResult UseModel(Class1 sv)
        {
            ViewBag.Id = sv.Id;
            ViewBag.Name = sv.Name;
            ViewBag.Marks = sv.Marks;
            return View();
        }

    }
}