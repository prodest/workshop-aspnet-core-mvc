using Negocio.Models;
using System.Collections.Generic;

namespace Negocio.Services.Base
{
    public interface IConfirmacaoService
    {
        IEnumerable<RespostaConvidadoModel> ListarPresentes();
        void Confirmar(RespostaConvidadoModel resposta);

    }
}
