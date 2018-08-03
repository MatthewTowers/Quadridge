using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Quadridge.Dtos;
using Quadridge.Models;

namespace Quadridge.Controllers.Api
{
    public class DealsController : ApiController
    {
        public QuadridgeContext _context;

        public DealsController()
        {
            _context = new QuadridgeContext();
        }

        // GET api/Deals
        public IHttpActionResult GetDeals()
        {
            var dealDtos = _context.Deals.ToList().Select(Mapper.Map<Deal, DealDto>);
            return Ok(dealDtos);
        }

        // GET api/Deals/5
        public IHttpActionResult GetDeal(int id)
        {
            var deal = _context.Deals.SingleOrDefault(d => d.DealId == id);
            if (deal == null)
                return NotFound();
            return Ok(Mapper.Map<Deal, DealDto>(deal));
        }

        // POST: api/Deals
        [HttpPost]
        public IHttpActionResult CreateDeal(DealDto dealDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var deal = Mapper.Map<DealDto, Deal>(dealDto);
            _context.Deals.Add(deal);
            _context.SaveChanges();

            dealDto.DealId = deal.DealId;

            return Created(new Uri(Request.RequestUri + "/" + deal.DealId), dealDto);
        }

        // PUT: api/Deals/5
        [HttpPut]
        public IHttpActionResult UpdateDeal(int id, DealDto dealDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var dealInDb = _context.Deals.SingleOrDefault(d => d.DealId == id);

            if (dealInDb == null)
                return NotFound();

            Mapper.Map(dealDto, dealInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE: api/Deals/5
        [HttpDelete]
        public IHttpActionResult DeleteDeal(int id)
        {
            var dealInDb = _context.Deals.SingleOrDefault(d => d.DealId == id);

            if (dealInDb == null)
                return NotFound();

            _context.Deals.Remove(dealInDb);

            _context.SaveChanges();

            return Ok();

        }
    }
}