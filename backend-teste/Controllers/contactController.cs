using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using backend_teste.Models;
using backend_teste.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend_teste.Controllers
{
    [ApiController]
    public class contactController : Controller

    {
        private readonly IContactRepository _contactRepository;

        public contactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpPost("contato")]
        public IActionResult Adicionar(ContactModel contact)
        {
            try
            {
                var contato = _contactRepository.Adicionar(contact);
                return Ok(contato);
            }
            catch (Exception erro)
            {
                return BadRequest (new {message = "Erro ao adicionar o contato.", error = erro.Message});
            }
        }

        [HttpGet("contatos")]
        public IActionResult Listar()
        {
            try
            {
                var contatos = _contactRepository.Listar();
                var qtde = contatos.Count();
                return Ok(new {total = qtde, contatos = contatos});
            }
            
            catch(Exception erro)
            {
                return BadRequest (new {message = "Erro ao buscar os contatos.", error = erro.Message});
            }
        }
        

    }
}