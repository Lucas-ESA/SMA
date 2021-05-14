using SMA.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Value_Objects
{
    public class Nome : EntityBase
    {
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Apelido { get; private set; }
    }
}