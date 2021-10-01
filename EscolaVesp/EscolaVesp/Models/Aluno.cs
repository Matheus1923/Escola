using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaVesp.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [Column("idaluno")]
        public Int32 IdAluno { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10 , ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("email")]

        public string Email { get; set; }

        [Required (ErrorMessage = "O campo é obrigatório")]
        [Column("mensalidade")]

        public Decimal Mensalidade { get; set; }
    }
}
