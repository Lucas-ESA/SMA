using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Resources.Usuario
{
    public class AtualizarUsuarioRequest : BaseRequest
    {
        public Guid ID { get; set; }
        public string Status { get; set; }
    }
}