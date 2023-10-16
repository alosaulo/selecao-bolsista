using ctc_selecao_bolsista.Data;
using Microsoft.EntityFrameworkCore;

namespace ctc_selecao_bolsista
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            using (var context = new AppDbContext())
            {

                // Aplica as migrações
                context.Database.Migrate();
                // Realiza o Seed
                DbContextSeed.SeedData(context);
            }

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Aluno/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            
            // Criar uma instância da classe Configuration
            /*var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Obter a string de conexão
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configurar e criar o DbContext
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;*/



        }
    }
}