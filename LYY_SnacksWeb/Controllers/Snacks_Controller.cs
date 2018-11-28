using LYY_SnacksWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LYY_SnacksWeb.Controllers
{
    public class Snacks_Controller : Controller
    {
        // GET: Snacks_
        //Snacks_Controller db = new Snacks_Controller();
        IUsers iu = new RUsers();
        public ActionResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Greeting = Hour < 12 ? "Good morning" : "Good afternoon";
            return View();
          
        }

        // GET: Snacks_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Snacks_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Snacks_/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "UsertypeId,UserName,password,Photo,Sex,Adress")] Users users)
        {

            if (ModelState.IsValid)
            {
                iu.Create(users);
                return RedirectToAction("Login");
            }

            return View(users);
        }

    [HttpGet]

    public ActionResult Login(string returnUrl)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View();
    }
    [HttpPost]
    public ActionResult Login(LoginViewModel model,String returnUrl)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        return View();
    }
    // GET: Snacks_/Edit/5
    public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Snacks_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Snacks_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Snacks_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
