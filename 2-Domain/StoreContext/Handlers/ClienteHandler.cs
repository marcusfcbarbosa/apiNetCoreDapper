using System;
using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Commands.ClienteCommands.Outputs;
using _2_Domain.StoreContext.Entities;
using _4_Shared.Commands;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using FluentValidator;

namespace _2_Domain.StoreContext.Handlers
{
    public class ClienteHandler : Notifiable,
     ICommandHandler<CriaClienteCommand>,
     ICommandHandler<CriaEnderecoCommand>
    {
        public ICommandResult Handle(CriaClienteCommand command)
        {
            //Verifica se CPF ja existe
            //verifica se email ja existe
            //cria as vo´s
            var nome = new Nome(command.PrimeiroNome, command.Sobrenome);
            var documento = new Documento(command.Documento,EnumDocumentType.CPF);
            var email = new Email(command.Email);

            //cria as entidades
            var cliente = new Cliente(nome,documento,email,command.Telefone);
            //validar as entidades e vo´s
            AddNotifications(nome.Notifications);
            AddNotifications(documento.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(cliente.Notifications);
            //inserir cliente no banco

            //envia convite no slack
            //envia email de boas vindas
            //retornar resultado para tela

            return new CriarClienteCommandResult(Guid.NewGuid(),nome.ToString(),email.Address);
        }

        public ICommandResult Handle(CriaEnderecoCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}