using SMA.Interface.Repository;
using SMA.Interface.Resources.Cargo;
using SMA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Services
{
    public class ServiceCargo : IServiceCargo
    {
        private readonly IRepositoryCargo _context;

        public Cargo Atualizar(AtualizarCargoRequest request)
        {
            var cargo = _context.ObterPorId(request.ID);
            cargo.Atualizar(request);

            return cargo;
        }

        public Cargo Cadastrar(BaseRequest request)
        {
            var cargo = new Cargo(request.Nome);
            _context.Adicionar(cargo);

            return cargo;
        }

        public string Excluir(Guid ID)
        {
            if (_context.Existe(ID))
            {
                _context.Excluir(ID);
                return "Cargo excluído com sucesso";
            }

            return "Não foi possível remover cargo";
        }
    }
}