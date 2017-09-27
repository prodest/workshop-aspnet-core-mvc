using Negocio.Base;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura.Repositorios
{
    public class RespostasConvidadosRepositorio : IRespostasConvidadosRepositorio, IDisposable
    {
        private ConfirmacaoPresencaContext _context;

        public RespostasConvidadosRepositorio(ConfirmacaoPresencaContext context)
        {
            _context = context;
        }

        public void Confirmar(RespostaConvidadoModel resposta)
        {
            _context.Respostas.Add(resposta);
            _context.SaveChanges();
        }

        public IQueryable<RespostaConvidadoModel> ListarPresentes()
        {
            return _context.Respostas.Where(r => r.Presenca == true);
        }

        public RespostaConvidadoModel Buscar(string email)
        {
            return _context.Respostas.SingleOrDefault(r => r.Email == email);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
