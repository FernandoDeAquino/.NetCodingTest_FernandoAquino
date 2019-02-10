using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Icatu.ListaLeitura.Modelos;
using Icatu.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Icatu.EmployeeManagerAPI.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IRepository<Funcionario> _repo;

        public FuncionariosController(IRepository<Funcionario> repository)
        {
            _repo = repository;
        }

        //Arquitetura REST significa REpresentational State Transfer

        [HttpGet]
        public IActionResult ListaDeFuncionarios()
        {
            var lista = _repo.All.Select(l => l.To_Api()).ToList();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult Recuperar(int id)
        {
            var model = _repo.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model.To_Api());
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] FuncUpload model)
        {
            if (ModelState.IsValid)
            {
                var Func = model.ToFuncionario();
                _repo.Incluir(Func);
                var uri = Url.Action("Recuperar", new { id = Func.Id }); // uri (Unform Resource Identifier)
                return Created(uri, Func); // Cód 201
            }
            return BadRequest(); // Retorna o código 400
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] FuncUpload model) // Código Identico ao Detalhes
        {
            if (ModelState.IsValid)
            {
                var funcionario = model.ToFuncionario();
                if (model.Capa == null)
                {
                    funcionario.ImagemCapa = _repo.All
                        .Where(l => l.Id == funcionario.Id)
                        .Select(l => l.ImagemCapa)
                        .FirstOrDefault();
                }
                _repo.Alterar(funcionario);
                return Ok(); // Cód 200
            }
            return BadRequest(); // Retorna o código 400
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            var model = _repo.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            _repo.Excluir(model);
            return NoContent(); // Cód 204 Ok más não existe mais nenhum conteúdo com esse identificador
        }

    }
}