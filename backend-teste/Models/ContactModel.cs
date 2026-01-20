using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_teste.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string MotivoContato { get; set;}
        public string Menssagem { get; set; }
    }
}