using Negocio.Base;
using Negocio.Models;
using Negocio.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class ConfirmacaoService : IConfirmacaoService
    {
        private IRespostasConvidadosRepositorio _repositorio;

        public ConfirmacaoService(IRespostasConvidadosRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Confirmar(RespostaConvidadoModel resposta)
        {
             _repositorio.Confirmar(resposta);
        }

        public IEnumerable<RespostaConvidadoModel> ListarPresentes()
        {
            return _repositorio.ListarPresentes();
        }
        
    }
}
