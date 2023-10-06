using System.ComponentModel.DataAnnotations;

namespace ctc_selecao_bolsista.Data.Entity
{
    public class Aluno
    {
        [Key]
        public int alunoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
    }
}
