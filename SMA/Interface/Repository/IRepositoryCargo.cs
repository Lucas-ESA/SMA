using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Repository
{
    public interface IRepositoryCargo
    {
        bool Existe(Guid ID);
        List<Cargo> ListarCargos();
        Cargo ObterPorId(Guid ID);
        Cargo Adicionar(Cargo cargo);
        Cargo Alterar(Cargo cargo);
        void Excluir(Guid ID);
    }
}