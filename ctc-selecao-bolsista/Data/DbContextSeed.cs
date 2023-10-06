using ctc_selecao_bolsista.Data.Entity;

namespace ctc_selecao_bolsista.Data
{
    public static class DbContextSeed
    {
        public static void SeedData(this AppDbContext context)
        {
            if (!context.Alunos.Any())
            {
                context.Alunos.AddRange(
                    new Aluno { Nome = "João Silva", DataNascimento = new DateTime(2000, 1, 1), Curso = "Engenharia" },
                    new Aluno { Nome = "Maria Oliveira", DataNascimento = new DateTime(1998, 5, 10), Curso = "Medicina" },
                    new Aluno { Nome = "Lucas Martins", DataNascimento = new DateTime(1997, 6, 15), Curso = "Direito" },
                    new Aluno { Nome = "Carla Pereira", DataNascimento = new DateTime(2001, 2, 20), Curso = "Biologia" },
                    new Aluno { Nome = "Roberto Alves", DataNascimento = new DateTime(2000, 8, 8), Curso = "Arquitetura" },
                    new Aluno { Nome = "Julia Fernandes", DataNascimento = new DateTime(1999, 4, 4), Curso = "Pedagogia" },
                    new Aluno { Nome = "Paulo Souza", DataNascimento = new DateTime(2002, 5, 14), Curso = "Matemática" },
                    new Aluno { Nome = "Beatriz Costa", DataNascimento = new DateTime(2001, 10, 30), Curso = "História" },
                    new Aluno { Nome = "Ricardo Dias", DataNascimento = new DateTime(1998, 12, 9), Curso = "Filosofia" },
                    new Aluno { Nome = "Aline Ribeiro", DataNascimento = new DateTime(1996, 3, 2), Curso = "Física" },
                    new Aluno { Nome = "Márcio Lopes", DataNascimento = new DateTime(2000, 6, 7), Curso = "Química" },
                    new Aluno { Nome = "Vanessa Moreira", DataNascimento = new DateTime(1995, 7, 17), Curso = "Letras" },
                    new Aluno { Nome = "Gustavo Rocha", DataNascimento = new DateTime(1997, 1, 22), Curso = "Administração" },
                    new Aluno { Nome = "Camila Santos", DataNascimento = new DateTime(1998, 9, 27), Curso = "Psicologia" },
                    new Aluno { Nome = "Rafaela Barbosa", DataNascimento = new DateTime(2001, 11, 5), Curso = "Sociologia" },
                    new Aluno { Nome = "Leonardo Cardoso", DataNascimento = new DateTime(2000, 4, 16), Curso = "Informática" }
                );

                context.SaveChanges();
            }
        }
    }
}
