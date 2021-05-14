using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMA.Interface.Resources.Usuario
{
    public class CadastrarUsuarioRequest
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Apelido { get; set; }
        public int Cargo { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}