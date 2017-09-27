using Microsoft.EntityFrameworkCore;
using Negocio.Models;
using System;

namespace Infraestrutura
{
    public class ConfirmacaoPresencaContext : DbContext
    {
        public DbSet<RespostaConvidadoModel> Respostas { get; set; }

        public ConfirmacaoPresencaContext(DbContextOptions<ConfirmacaoPresencaContext> options) : base(options)
        {
        }
        
    }
}
