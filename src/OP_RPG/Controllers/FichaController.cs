using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrdemParanormal.Data;

namespace OP_RPG.Controllers
{
    public class FichaController : Controller
    {
        private readonly AppDbContext _context;

        public FichaController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Fichas()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Origens()
        {
            var origens = await _context.Origem.ToListAsync();

            var selectList = new SelectList(origens, "OrigemID", "Origem");
            ViewBag.ddlOrigem = selectList;

            return View();
        }

        [Authorize]
        public async Task<IActionResult> GetOrigemDescricao(int id)
        {
            var origem = await _context.Origem.FirstOrDefaultAsync(o => o.OrigemID == id);

            if (origem.OrigemID != 3)
            {
                var data = new
                {
                    descOrigem = origem.Descricao,
                    descPericia1 = origem.Pericia_1,
                    descPericia2 = origem.Pericia_2,
                    nomePoder = origem.Poder_Origem,
                    descPoder = origem.Descricao_Poder
                };

                return Json(data);
            }
            else
            {
                var data = new
                {
                    descOrigem = origem.Descricao,
                    descPericia1 = "Duas à escolha do mestre.",
                    descPericia2 = "",
                    nomePoder = origem.Poder_Origem,
                    descPoder = origem.Descricao_Poder
                };

                return Json(data);
            }
        }

        [Authorize]
        public async Task<IActionResult> Classes()
        {
            var classes = await _context.Classe.ToListAsync();

            var selectList = new SelectList(classes, "ClasseID", "Classe");
            ViewBag.ddlClasse = selectList;

            return View();
        }

        [Authorize]
        public async Task<IActionResult> GetClasseDescricao(int id)
        {
            var classe = await _context.Classe.FirstOrDefaultAsync(o => o.ClasseID == id);

            var data = new
            {
                descClasse = classe.Descricao,
                descPtVidaInicial = classe.PtVidaInicial,
                descPtVidaNex = classe.PtVidaNex,
                descPtEsforcoInicial = classe.PtEsforcoInicial,
                descPtEsforcoNex = classe.PtEsforcoNex,
                descSanInicial = classe.SanidadeInicial,
                descSanidadeNex = classe.SanidadeNex,
                descPericiasTreinadas = classe.PericiasTreinadas,
                descProficiencias = classe.Proficiencias,
                descHabilidadeClasseTitle = classe.HabilidadeClasse,
                descHabilidadeClasse = classe.HabilidadeClasseDesc
            };

            return Json(data);
        }
    }
}