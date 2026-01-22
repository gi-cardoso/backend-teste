using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_teste.Models
{
    public class ContactModel
    {
        //[Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "O Telefone é obrigatório")]
        public string Telefone { get; set; }

        //[Required(ErrorMessage = "O Motivo de Contato é obrigatório")]
        public string MotivoContato { get; set;}

        //[Required(ErrorMessage = "A Mensagem é obrigatória")]
        public string Menssagem { get; set; }

        public DateTime DataHota { get; set; }
    }
}