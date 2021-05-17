using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Resources.Cargo
{
    public class AtualizarCargoRequest
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
    }
}