using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_teste.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_teste.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {}

        public DbSet<ContactModel> Contatos { get; set; }
    }
}