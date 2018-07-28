using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quadridge.Models;

namespace Quadridge.Controllers
{
    public class ClientsController : Controller
    {
        public ViewResult Index()
        {
            var clients = GetClients();

            return View (clients);
        }

        public ActionResult Details(int id)
        {
            var client = GetClients().SingleOrDefault(c => c.ClientId == id);

            if (client == null)
                return HttpNotFound();

            return View(client);
        }

        private IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client { ClientId = 1, Firstname = "John", Surname = "Smith" },
                new Client { ClientId = 2, Firstname = "Mary", Surname = "Williams"}
            };
        }
    }
}
