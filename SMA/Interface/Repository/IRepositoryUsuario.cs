using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Repository
{
    public interface IRepositoryUsuario
    {
        bool Existe(Guid ID);
        List<Usuario> ListarUsuarios();
        Usuario ObterPorId(Guid ID);
        Usuario Adicionar(Usuario Usuario);
        Usuario Alterar(Usuario Usuario);
        void Excluir(Guid ID);
    }
}