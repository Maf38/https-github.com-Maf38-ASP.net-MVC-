using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationNumber1.Models;

namespace WebApplicationNumber1.Controllers
{
    public class HomeController : Controller
    {
        private const string V = "Hello World MVC";

        // GET: Home
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))

                return View("Error");

            else
             ViewData["Nom"] = id;
            ViewBag.prenom = id + "ix";
            return View();
        }

        public string Index2()

        {
            return "Hello les contrôleurs";
        }

        public string index3(String id)
        {
            return "Bonjour " + id;
        }

        public ActionResult ListeClients()

        {

            Clients clients = new Clients();

            ViewData["Clients"] = clients.ObtenirListeClients();

            return View();

        }


        public ActionResult ChercheClient(string id)

        {

            ViewData["Nom"] = id;

            Clients clients = new Clients();


            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);

            if (client != null)

            {

                ViewData["Age"] = client.Age;

                return View("Trouve");

            }

            return View("NonTrouve");

        }

    }
}