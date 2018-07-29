using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quadridge.Models;
using System.Data.Entity;
using Quadridge.ViewModels;

namespace Quadridge.Controllers
{
    public class ClientsController : Controller
    {
        private QuadridgeContext _context;
        public ClientsController()
        {
            _context = new QuadridgeContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var provinces = _context.Provinces.ToList();
            var companies = _context.Companies.ToList();
            var viewModel = new NewCilientViewModel
            {
                Provinces = provinces,
                Companies = companies
            };

            return View(viewModel);
        }

        public ActionResult Create(Client client)
        {
            return View();
        }

        public ViewResult Index()
        {
            var clients = _context.Clients.ToList();

            return View (clients);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = _context.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

    }
}
