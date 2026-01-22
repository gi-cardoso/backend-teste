using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_teste.Data;
using backend_teste.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace backend_teste.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly BancoContext _context;

        public ContactRepository(BancoContext context)
        {
            _context = context;
        }
        public ContactModel Adicionar(ContactModel contact)
        {
            contact.DataHota = DateTime.Now;
            _context.Contatos.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public List<ContactModel> Listar([FromQuery] string? search, [FromQuery] int page = 1, [FromQuery] int limit = 10)
        {

            var contatos = _context.Contatos.ToList();

            if(search != null )
            {
                contatos = contatos.Where(c => c.MotivoContato.Contains(search) || c.Nome.Contains(search) || c.Email.Contains(search)).ToList();
            }


            var startIndex = (page - 1) * limit;
            var endIndex = startIndex + limit;

            var contatosPaginados = contatos.Skip(startIndex).Take(endIndex).ToList();

            return contatosPaginados;
        }
    }
}