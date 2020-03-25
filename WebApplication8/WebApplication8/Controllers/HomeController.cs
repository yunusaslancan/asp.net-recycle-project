using WebApplication8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        googleMapEntities1 context = new googleMapEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult Map()
        {
            
            return View();
        }

        

        public JsonResult GetAllLocation()
        {
            var data = context.Markers.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        

    }
    }
