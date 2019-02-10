using System.Linq;
using Icatu.ListaLeitura.Persistencia;
using Icatu.ListaLeitura.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Icatu.ListaLeitura.WebApp.Controllers
{
    [Authorize]
    public class FuncionarioController : Controller
    {
        private readonly IRepository<Funcionario> _repo;

        public FuncionarioController(IRepository<Funcionario> repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View(new FuncUpload());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novo(FuncUpload model)
        {
            if (ModelState.IsValid)
            {
                _repo.Incluir(model.ToFuncionario());
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ImagemCapa(int id)
        {
            byte[] img = _repo.All
                .Where(l => l.Id == id)
                .Select(l => l.ImagemCapa)
                .FirstOrDefault();
            if (img != null)
            {
                return File(img, "image/png");
            }
            return File("~/images/fotos/capa-vazia.png", "image/png");
        }

        [HttpGet]
        public IActionResult Recuperar(int id)
        {
            var model = _repo.Find(id);
            if(model == null)
            {
                return NotFound();
            }
            return Json(model.ToModel());
           
        }
        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var model = RecuperaLivro(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model.ToModel());
        }
        public Funcionario RecuperaLivro(int id)
        {
            return _repo.Find(id);
        }

        //[HttpGet]
        //public IActionResult DetalhesSemHTML(int id)
        //{
        //    var model = RecuperaLivro(id);
        //    if (model == null)
        //    {
        //        return NotFound();
        //    }
        //    //return View(model.ToModel());
        //    //XML
        //    //JSON
        //    model.ImgFuncionario = null;
        //    return Json(model.ToModel());
        //}


        public ActionResult<FuncUpload> DetalhesJson(int id)
        {
            var model = RecuperaLivro(id);
            if(model == null)
            {
                return NotFound();
            }

            return model.ToModel();
        }

        [HttpGet]
        public Funcionario LivroJson(int id)
        {
            return _repo.Find(id);
        }

        [HttpGet]
        public ActionResult<Funcionario> FuncHttp(int id)
        {
            var FuncFind = _repo.Find(id);
            if (FuncFind == null)
            {
                return NotFound();
            }
            return FuncFind;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detalhes(FuncUpload model)
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
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(int id)
        {
            var model = _repo.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            _repo.Excluir(model);
            return RedirectToAction("Index", "Home");
        }
    }
}