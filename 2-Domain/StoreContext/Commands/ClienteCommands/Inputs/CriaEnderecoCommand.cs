using System;
using _4_Shared.Commands;
using _4_Shared.Enum;
using FluentValidator;

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
            throw new NotImplementedException();
        }
    }
}