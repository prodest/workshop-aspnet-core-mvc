using Negocio.Base;
using Negocio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura.Repositorios
{
    public class RespostasConvidadosRepositorio : IRespostasConvidadosRepositorio
    {
        public void Confirmar(RespostaConvidadoModel resposta)
        {
            using (var db = new ConfirmacaoPresencaContext())
            {
                db.Respostas.Add(resposta);
                db.SaveChanges();
            }
        }

        public IEnumerable<RespostaConvidadoModel> ListarPresentes()
        {
            using (var db = new ConfirmacaoPresencaContext())
            {
                return db.Respostas.Where(r => r.Presenca == true).ToList();
            }
        }

        public RespostaConvidadoModel Buscar (string email)
        {
            using (var db = new ConfirmacaoPresencaContext())
            {
                return db.Respostas.SingleOrDefault(r => r.Email == email);
            }

            
        }
    }
}
