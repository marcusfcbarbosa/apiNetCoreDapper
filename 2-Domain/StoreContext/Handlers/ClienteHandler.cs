using System;
using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Commands.ClienteCommands.Outputs;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Repositories;
using _2_Domain.StoreContext.Repositories.Interfaces;
using _2_Domain.StoreContext.Services;
using _2_Domain.StoreContext.Services.Interfaces;
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
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;
        public ClienteHandler(IClienteRepository clienteRepository,
        IEmailService emailService){
                _clienteRepository =clienteRepository;
                _emailService = emailService;
        }

        public ICommandResult Handle(CriaClienteCommand command)
        {
            //Verifica se CPF ja existe
            if(_clienteRepository.CheckaDocumento(command.Documento)){
                AddNotification("Documento","Este CPF ja esta em uso");
                return null;
            }

            if(_clienteRepository.checkaEmail(command.Email)){
                AddNotification("Email","Este Email ja esta em uso");
                return null;
            }
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

            if(Invalid)
                return null;
            //inserir cliente no banco

            _clienteRepository.Save(cliente);
            //envia convite no slack
            //envia email de boas vindas
            _emailService.EnviaEmail(email.Address, "teste@teste.com","Bem vindo", "seja Bem vindo");
            //retornar resultado para tela

            return new CriarClienteCommandResult(cliente.Id,nome.ToString(),email.Address);
        }

        public ICommandResult Handle(CriaEnderecoCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}