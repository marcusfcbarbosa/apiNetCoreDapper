using System;
using _4_Shared.Commands;

namespace _2_Domain.StoreContext.Commands.ClienteCommands.Outputs
{
    public class CriarClienteCommandResult : ICommandResult
    {
        public CriarClienteCommandResult(){}

        public CriarClienteCommandResult(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public Guid Id { get; set; }
        public String Nome { get;  set; }
        public String Email { get;  set; }
        
        
    }
}