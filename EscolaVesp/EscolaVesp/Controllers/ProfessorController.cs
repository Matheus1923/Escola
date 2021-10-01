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
    public class ProfessorController : ControllerBase
    {
        public Contexto contexto { get; set; }

        public ProfessorController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }

        [HttpGet]
        public List<Professor> Get()
        {
            return contexto.Professors.ToList();
        }


        [HttpGet("{id}")]
        public Professor Get(int id)
        {
            return contexto.Professors.First(e => e.IdProfessor == id);
        }


        [HttpGet("idProfessor/{idProfessor}")]
        public List<Professor> filtrar(int id)
        {
            return contexto.Professors.Where(e => e.IdProfessor == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Professor>> Create(Professor Professor)
        {
            Professor.IdProfessor = 0;
            contexto.Professors.Add(Professor);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Professor.IdProfessor, Professor });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Professor>> Update(Professor Professor)
        {
            contexto.Professors.Update(Professor);
            await contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Professor.IdProfessor, Professor });
        }
    }
}
