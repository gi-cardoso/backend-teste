using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_teste.Data;
using backend_teste.Models;

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

        public List<ContactModel> Listar()
        {
            return _context.Contatos.ToList();
        }
    }
}