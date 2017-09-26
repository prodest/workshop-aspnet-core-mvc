using Microsoft.EntityFrameworkCore;
using Negocio.Models;

namespace Infraestrutura
{
    public class ConfirmacaoPresencaContext : DbContext
    {
        public DbSet<RespostaConvidadoModel> Respostas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ConfirmacaoPresenca;Trusted_Connection=True;");
        }
        
    }
}
