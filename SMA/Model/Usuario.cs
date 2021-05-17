using SMA.Enum;
using SMA.Interface.Resources.Usuario;
using SMA.Model.Base;
using SMA.Utility;
using System;

namespace SMA.Model
{
    public class Usuario : EntityBase
    {
        public Usuario(Cargo cargo, BaseRequest request)
        {
            Validate(request);
            Cargo = cargo;
            DtNascimento = request.DtNascimento;
            Status = StatusUsuarioOptions.Pendente.ToString();
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Apelido { get; private set; }
        public Cargo Cargo { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public DateTime DtNascimento { get; private set; }
        public string Status { get; private set; }

        internal void Atualizar(Cargo cargo, BaseRequest request, string status)
        {
            Cargo = cargo;
            DtNascimento = request.DtNascimento;

            Validate(request);

            if (System.Enum.TryParse<StatusUsuarioOptions>(status, out _))
            {
                Status = status;
            }
        }

        internal void Validate(BaseRequest request)
        {
            if (!string.IsNullOrEmpty(request.PrimeiroNome) && request.PrimeiroNome.Length < 255)
            {
                PrimeiroNome = request.PrimeiroNome;
            }

            if (!string.IsNullOrEmpty(request.UltimoNome) && request.UltimoNome.Length < 255)
            {
                UltimoNome = request.UltimoNome;
            }

            if (!string.IsNullOrEmpty(request.Apelido) && request.Apelido.Length < 255)
            {
                Apelido = request.Apelido;
            }

            if (!string.IsNullOrEmpty(request.Senha) || request.Senha.Length >= 6)
            {
                Senha = Crypto.Encode(request.Senha);
            }

            if (Mail.IsValid(request.Email))
            {
                Email = request.Email;
            }
        }
    }
}