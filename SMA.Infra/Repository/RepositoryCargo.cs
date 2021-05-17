using SMA.Interface.Repository;
using SMA.Model;
using Study.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Infra.Repository
{
    public class RepositoryCargo : IRepositoryCargo
    {
        private readonly Context _context;

        public RepositoryCargo(Context context)
        {
            _context = context;
        }

        public Cargo Adicionar(Cargo cargo)
        {
            _context.Cargos.Add(cargo);

            return cargo;
        }

        public Cargo Alterar(Cargo cargo)
        {
            var old = ObterPorId(cargo.ID);
            old = cargo;

            return old;
        }

        public void Excluir(Guid ID)
        {
            _context.Cargos.Remove(ObterPorId(ID));
        }

        public bool Existe(Guid ID)
        {
            var cargo = ObterPorId(ID);

            if(cargo != null)
            {
                return true;
            }

            return false;
        }

        public List<Cargo> ListarCargos()
        {
            return _context.Cargos.ToList();
        }

        public Cargo ObterPorId(Guid ID)
        {
            return _context.Cargos.Find(ID);
        }
    }
}