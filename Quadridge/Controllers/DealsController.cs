using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quadridge.ViewModels;
using Quadridge.Models;
using System.Net;

namespace Quadridge.Controllers
{
    public class DealsController : Controller
    {
        private QuadridgeContext _context;
        public DealsController()
        {
            _context = new QuadridgeContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var clients = _context.Clients.ToList();
            var viewModel = new NewDealViewModel
            {
                clients = clients
            };

            return View(viewModel);
        }

        public ActionResult Create(Deal deal)
        {
            return View();
        }

        public ViewResult Index()
        {
            var deals = _context.Deals.ToList();

            return View(deals);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deal deal = _context.Deals.Find(id);

            if (deal == null)
            {
                return HttpNotFound();
            }
            return View(deal);
        }
    }
}
