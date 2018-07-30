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
        /* VIEWING DEAL INFORMATION */
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
            Deal deal = _context.Deals.First(d => d.DealId == id);

            if (deal == null)
            {
                return HttpNotFound();
            }
            return View(deal);
        }
        /* MODIFYING DEAL INFORMATION */
        public ActionResult New()
        {
            var clients = _context.Clients.ToList();
            var viewModel = new DealFormViewModel
            {
                Banks = _context.Banks.ToList(),
                DealTypes = _context.DealTypes.ToList(),
                Lawyers = _context.Lawyers.ToList(),
                Clients = _context.Clients.ToList(),
                Statuses = _context.Status.ToList()
            };

            return View("DealsForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var deal = _context.Deals.SingleOrDefault(d => d.DealId == id);

            if (deal == null)
                return HttpNotFound();

            var viewModel = new DealFormViewModel(deal)
            {
                Banks = _context.Banks.ToList(),
                DealTypes = _context.DealTypes.ToList(),
                Lawyers = _context.Lawyers.ToList(),
                Clients = _context.Clients.ToList(),
                Statuses = _context.Status.ToList()
            };
            return View("DealForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Deal deal)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new DealFormViewModel(deal)
                {
                    Clients = _context.Clients.ToList()
                };
                return View("MovieForm", viewModel);
            }

            if (deal.DealId == 0)
            {
                deal.Date = DateTime.Now;
                _context.Deals.Add(deal);
            }
            else
            {
                var dealInDb = _context.Deals.Single(c => c.DealId == deal.DealId);

                // Mapper.Map(customer, customerInDb)

                dealInDb.Name = deal.Name;
                dealInDb.DealTypeId = deal.DealTypeId;
                dealInDb.StatusId = deal.StatusId;

                if (deal.RevenueId != null)
                    dealInDb.RevenueId = deal.RevenueId;

                if (deal.BankId != null)
                    dealInDb.BankId = deal.BankId;
                
                if (deal.LawyerId != null)
                    dealInDb.LawyerId = deal.LawyerId;


            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Deals");
        }
    }
}
