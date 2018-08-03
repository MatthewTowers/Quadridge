using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quadridge.Models;
using AutoMapper;
using Quadridge.Dtos;

namespace Quadridge.Controllers.Api
{
    public class ClientsController : ApiController
    {
        public QuadridgeContext _context;

        public ClientsController()
        {
            _context = new QuadridgeContext();
        }

        // GET api/clients
        public IHttpActionResult GetClients()
        {
            var clientDtos = _context.Clients.ToList().Select(Mapper.Map<Client, ClientDto>);
            return Ok(clientDtos);
        }

        // GET api/Clients/5
        public IHttpActionResult GetClient(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.ClientId == id);
            if (client == null)
                return NotFound();
            return Ok(Mapper.Map<Client, ClientDto>(client));
        }

        // POST: api/Clients
        [HttpPost]
        public IHttpActionResult CreateCustomer(ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var client = Mapper.Map<ClientDto, Client>(clientDto);
            _context.Clients.Add(client);
            _context.SaveChanges();

            clientDto.ClientId = client.ClientId;

            return Created(new Uri(Request.RequestUri + "/" + client.ClientId), clientDto);
        }

        // PUT: api/Clients/5
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clientInDb = _context.Clients.SingleOrDefault(c => c.ClientId == id);

            if (clientInDb == null)
                return NotFound();

            Mapper.Map(clientDto, clientInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE: api/Clients/5
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var clientInDb = _context.Clients.SingleOrDefault(c => c.ClientId == id);

            if (clientInDb == null)
                return NotFound();

            _context.Clients.Remove(clientInDb);

            _context.SaveChanges();

            return Ok();

        }
    }
}