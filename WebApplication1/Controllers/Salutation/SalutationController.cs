using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;



namespace WebApplication1.Controllers.Salutation
{
    public class SalutationController : Controller
    {
        // GET: /Salutation/
        public ActionResult Index()
        {
            Visitor client = new Visitor();
            return View(client);
        }
        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Visitor visiteur)
        {
            Visitor client = new Visitor();
            string name = "";
            string firstName = "";
            string mail = "";
            string telephone = "";
            string code = "";

            name = Request.Form["visitor_name"];
            firstName = Request.Form["visitor_firstname"];
            mail = Request.Form["visitor_mail"];
            telephone = Request.Form["visitor_telephone"];
            code = Request.Form["visitor_code"];
      

            client.Name = name;
            client.FirstName = firstName;
            client.Mail = mail;
            client.Telephone = telephone;
            client.Code = code;

            ViewData["name"] = "Nom: " + name;
            ViewData["firstname"] = "Prénom: " + firstName;
            ViewData["mail"] = "Email: " + mail;
            ViewData["telephone"] = "Telephone: " + telephone;
            ViewData["code"] = "Code: " + code;


            return View("Index", client);
        }

      
    }
}