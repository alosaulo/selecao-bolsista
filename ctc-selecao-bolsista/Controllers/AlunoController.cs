using ctc_selecao_bolsista.Data;
using ctc_selecao_bolsista.Data.Entity;
using ctc_selecao_bolsista.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ctc_selecao_bolsista.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Alunos")]
        public IActionResult ListarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            using (var context = new AppDbContext()) 
            {
                alunos = context.Alunos.ToList();
            }

            return View();
        }

        [Route("Alunos/Formulario")]
        public IActionResult FormularioAluno()
        {
            return View();
        }

        [Route("Alunos/Criar")]
        public IActionResult CriarAluno() 
        { 
            return RedirectToAction("Index");
        }

        [Route("Alunos/Deletar/{id}")]
        public IActionResult DeletarAluno(int id)
        {
            return RedirectToAction("Index");
        }

        [Route("Alunos/Atualizar/{id}")]
        public IActionResult AtualizarAluno(int id)
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}