using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_teste.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend_teste.Repository
{
    public interface IContactRepository
    {
        ContactModel Adicionar(ContactModel contact);

        List<ContactModel> Listar([FromQuery] string? search, [FromQuery] int page, [FromQuery] int limit);
    }
}