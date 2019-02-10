using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Icatu.ListaLeitura.Modelos;
using Icatu.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Lista = Icatu.ListaLeitura.Modelos.ListaLeitura;


namespace Icatu.EmployeeManagerAPI.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListaFuncionariosController : ControllerBase
    {
        private readonly IRepository<Funcionario> _repo;

        public ListaFuncionariosController(IRepository<Funcionario> repository)
        {
            _repo = repository;
        }

        private Lista CriaLista(TipoListaLeitura tipo)
        {
            return new Lista
            {
                Tipo = tipo.ParaString(),
                Funcionario = _repo.All
                              .Where(l => l.Lista == tipo)
                              .Select(l => l.To_Api())
                              .ToList()
            };
        }

        [HttpGet]
        public IActionResult TodasListas()
        {
            Lista Ti = CriaLista(TipoListaLeitura.TI);
            Lista Marketing = CriaLista(TipoListaLeitura.Marketing) ;
            Lista Vendas = CriaLista(TipoListaLeitura.Vendas);
            var colecao = new List<Lista> { Ti, Marketing, Vendas };
            return Ok(colecao);
        }
        
        [HttpGet("{tipo}")]
        public IActionResult Recuperar(TipoListaLeitura tipo)
        {
            var lista = CriaLista(tipo);
            return Ok(lista);
        }

    }
}