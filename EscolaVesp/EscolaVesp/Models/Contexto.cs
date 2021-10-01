using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaVesp.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Professor> Professors { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {


        }
    }
}
