using SMA.Interface.Resources.Usuario;
using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Services
{
    public class UsuarioService : IUsuario
    {
        public Usuario Atualizar(AtualizarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }

        public string Autenticar(string username, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario Cadastrar(CadastrarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Guid ID)
        {
            throw new NotImplementedException();
        }
    }
}