using SMA.Interface.Resources.Cargo;
using SMA.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Model
{
    public class Cargo : EntityBase
    {
        public Cargo(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        internal void Atualizar(AtualizarCargoRequest request)
        {
            if (!string.IsNullOrEmpty(request.Nome))
            {
                Nome = request.Nome;
            }
        }
    }
}