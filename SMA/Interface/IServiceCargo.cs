using SMA.Interface.Resources.Cargo;
using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface
{
    public interface IServiceCargo
    {
        Cargo Cadastrar(BaseRequest request);
        Cargo Atualizar(AtualizarCargoRequest request);
        string Excluir(Guid ID);
    }
}