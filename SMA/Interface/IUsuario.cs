using SMA.Interface.Resources.Usuario;
using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface
{
    public interface IUsuario
    {
        Usuario Cadastrar(CadastrarUsuarioRequest request);
        Usuario Atualizar(AtualizarUsuarioRequest request);
        string Excluir(Guid ID);
        string Autenticar(string username, string senha);
    }
}