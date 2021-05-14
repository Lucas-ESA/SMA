using SMA.Model.Base;
using SMA.Value_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Model
{
    public class Usuario : EntityBase
    {
        public Nome Nome { get; private set; }
        public Cargo Cargo { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public DateTime DtNascimento { get; private set; }
        public string Status { get; private set; }
    }
}