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

            return View(alunos);
        }

        [Route("Alunos/Formulario")]
        public IActionResult FormularioAluno()
        {
            return View();
        }

        [Route("Alunos/Criar")]
        public IActionResult CriarAluno(Aluno aluno) 
        { 
            
            return RedirectToAction("Index");
        }

        [Route("Alunos/Deletar/{id}")]
        public IActionResult DeletarAluno(int id)
        {
            using (AppDbContext context = new AppDbContext()) 
            {
                Aluno aluno = context.Alunos.Find(id);
                context.Remove(aluno);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [Route("Alunos/Atualizar/{id}")]
        public IActionResult AtualizarAluno(int id)
        {
            Aluno aluno = null;
            using(AppDbContext context = new AppDbContext())
            {
                aluno = context.Alunos.Find(id);
            }
            return View("FormularioAluno", aluno);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}