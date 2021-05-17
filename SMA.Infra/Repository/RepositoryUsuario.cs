using SMA.Model;
using SMA.Repository;
using Study.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Infra.Repository
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly Context _context;

        public RepositoryUsuario(Context context)
        {
            _context = context;
        }

        public Usuario Adicionar(Usuario user)
        {
            _context.Usuarios.Add(user);
            return user;
        }

        public Usuario Alterar(Usuario user)
        {
            var usuario = _context.Usuarios.Find(user.ID);
            usuario = user;

            return usuario;
        }

        public bool Autenticar(string usuario, string senha)
        {
            var result = _context.Usuarios.SingleOrDefault(x => x.Apelido == usuario && x.Senha == senha);

            if(result != default)
            {
                return true;
            }

            return false;
        }

        public void Excluir(Guid ID)
        {
            _context.Usuarios.Remove(_context.Usuarios.Find(ID));
        }

        public bool Existe(Guid ID)
        {
            var existe = _context.Usuarios.Find(ID);

            if(existe != null)
            {
                return true;
            }

            return false;
        }

        public List<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ObterPorId(Guid ID)
        {
            return _context.Usuarios.Find(ID);
        }
    }
}