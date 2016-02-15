using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var database = new FakeContactDatabase();

            //get contacts
            var contacts = database.GetAll();

            //inject contact data into the index view
            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }
        
        public ActionResult Edit()
        {
            //load the id from routedata
            int contactId = int.Parse(RouteData.Values["id"].ToString());

            var database = new FakeContactDatabase();
            var contact = database.GetById(contactId);

            return View(contact);
        }

        [HttpPost]
        public ActionResult AddContact()
        {
            //create a contact
            var c = new Contact();

            // get the data from the text boxes
            c.Name = Request.Form["Name"];
            c.PhoneNumber = Request.Form["PhoneNumber"];

            //create Fake Db
            var database = new FakeContactDatabase();

            //add the info to db 
            database.Add(c);

            //nav to home view 
            return RedirectToAction("Index");

        }
    }
}