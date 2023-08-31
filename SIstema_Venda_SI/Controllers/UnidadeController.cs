using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Venda_SI.Model.Models;
using Sistema_Venda_SI.Model.Service;

namespace SIstema_Venda_SI.Controllers
{
    public class UnidadeController : Controller
    {

        private ServiceUnidade _ServiceUnidade;

        public UnidadeController(DBSISTEMASContext context)
        {
            _ServiceUnidade = new ServiceUnidade();
        }

        public async Task<IActionResult> Index()
        {
            var listaUnidades = await _ServiceUnidade.oRepositoryUnidade.SelecionarTodosAsync();
            return View(listaUnidades);
        }

        public async Task<IActionResult> Details(int id)
        {
            var unidade = await _ServiceUnidade.oRepositoryUnidade.SelecionarPkAsync(id);
            return View(unidade);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
     
        public async Task<IActionResult> Create(Unidade unidade)
        {
            if (ModelState.IsValid)
            {
                await _ServiceUnidade.oRepositoryUnidade.IncluirAsync(unidade);
                return View(unidade);
            }
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            var unidade = await _ServiceUnidade.oRepositoryUnidade.SelecionarPkAsync(id);
            return View(unidade);
        }

        [HttpPost]
      
        public async Task<ActionResult> Edit(Unidade unidade)
        {
            if (ModelState.IsValid)
            {
                await _ServiceUnidade.oRepositoryUnidade.AlterarAsync(unidade);
                return View(unidade);
            }
            return View();
        }

        public async Task<ActionResult> Delete(int id)
        {
            await _ServiceUnidade.oRepositoryUnidade.ExcluirAsync(id);
            return RedirectToAction ("Index");     
        }
    }
}
