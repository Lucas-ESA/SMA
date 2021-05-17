using SMA.Interface.Resources.Usuario;
using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface
{
    public interface IServiceUsuario
    {
        Usuario Cadastrar(BaseRequest request);
        Usuario Atualizar(AtualizarUsuarioRequest request);
        string Excluir(Guid ID);
        bool Autenticar(string username, string senha);
    }
}