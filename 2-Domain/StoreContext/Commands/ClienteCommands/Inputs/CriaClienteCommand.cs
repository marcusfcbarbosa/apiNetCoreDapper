using System;
using _4_Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace _2_Domain.StoreContext.Commands.ClienteCommands.Inputs
{
    public class CriaClienteCommand : Notifiable, ICommand
    {
        public String PrimeiroNome { get;  set; }
        public String Sobrenome { get; set; }
        public string Documento { get;  set; }
        public String Email { get;  set; }
        public String Telefone { get;  set; }

        public bool Valid(){
                AddNotifications(new ValidationContract()
                    .Requires()
                    .IsNotNull(Telefone,"CriaClienteCommand.Telefone","Telefone é obrigatório")
                    .IsEmail(Email, "CriaClienteCommand.Email", "E-mail inválido")
                    .HasMinLen(PrimeiroNome, 3,"CriaClienteCommand.PrimeiroNome"," Primeiro  Nome deve conter pelo menos 3 caracteres")
                    .HasMinLen(Sobrenome, 3,"CriaClienteCommand.Sobrenome","Sobrenome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(PrimeiroNome, 40,"CriaClienteCommand.PrimeiroNome","Primeiro Nome deve conter  menos de 40 caracteres")
                    .HasMaxLen(Sobrenome, 40,"CriaClienteCommand.Sobrenome","Sobrenome deve conter  menos de 40 caracteres")
                    .HasLen(Documento,11,"CriaClienteCommand.Documento","Fomato invalido de documento")
                );
            return Valid();
        }

        //se o usuario ja existe no banco (Email)

        //se o cpf existe no banco (Cpf)

    }
}