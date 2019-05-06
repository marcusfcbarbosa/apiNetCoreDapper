using System;
using _4_Shared.Commands;
using _4_Shared.Enum;
using FluentValidator;
using FluentValidator.Validation;

namespace _2_Domain.StoreContext.Commands.ClienteCommands.Inputs
{
    public class CriaEnderecoCommand  : Notifiable, ICommand
    {
        public Guid Id { get;set; }
        public string Rua { get;  set; }
        public string Numero { get;  set; }
        public string Complemento { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }
        public string Pais { get;  set; }
        public string Cep { get;  set; }
        public TipoEndereco TipoEndereco { get;  set; }

        public bool Valid()
        {

         AddNotifications(new ValidationContract()
                    .Requires()
                    .HasLen(Id.ToString(),36, "ClienteId","Identificador de cliente inválido")
                    .IsNotNull(Rua,"Rua","Rua é obrigatório")
                    .IsNotNull(Numero,"Numero","Numero é obrigatório")
                    .IsNotNull(Complemento,"Complemento","Complemento é obrigatório")
                    .IsNotNull(Bairro,"Bairro","Bairro é obrigatório")
                    .IsNotNull(Cidade,"Cidade","Cidade é obrigatório")
                    .IsNotNull(Estado,"Estado","Estado é obrigatório")
                    .IsNotNull(Pais,"Pais","Pais é obrigatório")
                    .IsTrue(ValidaCep(Cep),"Cep","Formato de CEP inválido")
                );
            return Valid();
        }

        public static bool ValidaCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
                //txt.Text = cep;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}