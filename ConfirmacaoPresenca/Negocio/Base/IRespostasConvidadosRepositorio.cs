using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Base
{
    public interface IRespostasConvidadosRepositorio
    {
        IQueryable<RespostaConvidadoModel> ListarPresentes(); 
        void Confirmar(RespostaConvidadoModel resposta);
        RespostaConvidadoModel Buscar(string email);
    }
}
