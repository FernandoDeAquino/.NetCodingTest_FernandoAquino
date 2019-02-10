using Icatu.ListaLeitura.Persistencia;
using Icatu.ListaLeitura.Modelos;
using Icatu.ListaLeitura.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Icatu.ListaLeitura.WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IRepository<Funcionario> _repo;

        public HomeController(IRepository<Funcionario> repository)
        {
            _repo = repository;
        }

        private IEnumerable<FuncApi> ListaDoTipo(TipoListaLeitura tipo)
        {
            return _repo.All
                .Where(l => l.Lista == tipo)
                .Select(l => l.ToApi())
                .ToList();
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                TI = ListaDoTipo(TipoListaLeitura.TI),
                Marketing = ListaDoTipo(TipoListaLeitura.Marketing),
                Vendas = ListaDoTipo(TipoListaLeitura.Vendas)
            };
            return View(model);
        }
    }
}