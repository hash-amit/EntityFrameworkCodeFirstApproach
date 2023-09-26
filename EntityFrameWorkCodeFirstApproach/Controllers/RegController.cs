using EntityFrameWorkCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkCodeFirstApproach.Controllers
{
    public class RegController : Controller
    {
        DatabaseContext dbc = new DatabaseContext();

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddUser(TblRegistration _tr)
        {
            dbc.TblRegistrations.Add(_tr);
            dbc.SaveChanges();
            return View();
        }


    }
}