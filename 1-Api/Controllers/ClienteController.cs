using System;
using System.Net;
using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Commands.ClienteCommands.Outputs;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Handlers;
using _2_Domain.StoreContext.Queries;
using _2_Domain.StoreContext.Repositories.Interfaces;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using Microsoft.AspNetCore.Mvc;
 
namespace _1_Api.Controllers
{
    [Route("api/v1/Cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteHandler _handler;
        public ClienteController(IClienteRepository clienteRepository,
                                 ClienteHandler handler){
                _clienteRepository = clienteRepository;
                _handler = handler;
        }
       
        [HttpGet("")]
        
        public IActionResult Get(){
            return Ok(_clienteRepository.Get());
        }

        [HttpGet("{id:Guid}")]
        [ResponseCache(Duration=60)]
        public IActionResult GetById(Guid id){
               return Ok(_clienteRepository.GetById(id));
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult Delete(Guid id){

            return Ok();
        }


        [HttpGet("{id:Guid}/Pedidos")]
        public IActionResult GetPedidosByIdCliente(Guid id){

            return Ok();
        }

        [HttpPost("")]
        public IActionResult Post([FromBody]CriaClienteCommand  command){
            var result  = (CriarClienteCommandResult)_handler.Handle(command);
            return Ok(result);
        }

        [HttpPut("{id:Guid}")]
        public IActionResult Put([FromBody]Cliente  cliente){
            return Ok();
        }
    }
}