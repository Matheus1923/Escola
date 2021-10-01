using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaVesp.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Key]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [Column("idprofessor")]
        public Int32 IdProfessor { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Column("identificacao")]

        public int Identificacao { get; set; }
    }
}
