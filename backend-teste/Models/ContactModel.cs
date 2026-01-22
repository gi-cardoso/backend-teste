using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend_teste.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [Phone(ErrorMessage = "O telefone informado não é válido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Motivo de Contato é obrigatório")]
        [AllowedValues(
            "duvida", "sugestao", "reclamacao", "elogio", "outro",
            ErrorMessage = "Motivo de contato inválido"
        )]
        public string MotivoContato { get; set; }


        [Required(ErrorMessage = "A Mensagem é obrigatória")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 e 500 caracteres")]
        public string Menssagem { get; set; }

        public DateTime DataHota { get; set; }
    }
}