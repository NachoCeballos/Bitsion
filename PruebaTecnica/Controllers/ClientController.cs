using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.DataAccess;
using PruebaTecnica.Entities;
using PruebaTecnica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private ClientRepository _clientRepository;

        public ClientController(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Post(Client entity)
        {
            _clientRepository.Insert(entity);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Client entity)
        {
            _clientRepository.Update(entity);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Client entity)
        {
            _clientRepository.Delete(entity);
            return Ok();
        }
    }
}
