using EscolaVesp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaVesp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public Contexto contexto { get; set; }

        public AlunoController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]
        public List<Aluno> Get()
        {
            return contexto.Alunos.ToList();
        }


        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return contexto.Alunos.First(e => e.IdAluno == id);
        }


        [HttpGet("idAluno/{idAluno}")]
        public List<Aluno> filtrar(int id)
        {
            return contexto.Alunos.Where(e => e.IdAluno == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Aluno>> Create(Aluno Aluno)
        {
            Aluno.IdAluno = 0;
            contexto.Alunos.Add(Aluno);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aluno.IdAluno, Aluno });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Aluno>> Update(Aluno Aluno)
        {
            contexto.Alunos.Update(Aluno);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Aluno.IdAluno, Aluno });
        }
    }
}
