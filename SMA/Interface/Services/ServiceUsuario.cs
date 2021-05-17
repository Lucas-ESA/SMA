using SMA.Interface.Repository;
using SMA.Interface.Resources.Usuario;
using SMA.Model;
using SMA.Repository;
using System;

namespace SMA.Interface.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        public readonly IRepositoryUsuario _usuario;
        public readonly IRepositoryCargo _cargo;

        public ServiceUsuario(IRepositoryUsuario repository)
        {
            _usuario = repository;
        }

        public Usuario Atualizar(AtualizarUsuarioRequest request)
        {
            var user = _usuario.ObterPorId(request.ID);
            var cargo = _cargo.ObterPorId(request.Cargo);

            user.Atualizar(cargo, request, request.Status);

            return user;
        }

        public bool Autenticar(string username, string senha)
        {
            if(!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(senha))
            {
                return _usuario.Autenticar(username, senha);
            }

            return false;
        }

        public Usuario Cadastrar(BaseRequest request)
        {
            var cargo = _cargo.ObterPorId(request.Cargo);
            var user = new Usuario(cargo, request);

            _usuario.Adicionar(user);
            return user;
        }

        public string Excluir(Guid ID)
        {
            if (_usuario.Existe(ID))
            {
                _usuario.Excluir(ID);
                return "Usuário excluído com sucesso";
            }

            return "Não foi posível excluir usuário";
        }
    }
}