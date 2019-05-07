using System;
using _2_Domain.StoreContext.Commands.ClienteCommands.Inputs;
using _2_Domain.StoreContext.Entities;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using Microsoft.AspNetCore.Mvc;

namespace _1_Api.Controllers
{
    [Route("clientes")]
    public class ClienteController : Controller
    {

        [HttpGet]
        public IActionResult Get(){

            return Ok();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById(Guid id){

            return Ok();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult Delete(Guid id){

            return Ok();
        }


        [HttpGet]
        [Route("{id:Guid}/Pedidos")]
        public IActionResult GetPedidosByIdCliente(Guid id){

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody]CriaClienteCommand  command){
            
            var nome= new Nome(command.PrimeiroNome,command.Sobrenome);
            var documento = new Documento(command.Documento,EnumDocumentType.CPF);
            var email = new Email(command.Email);
            var _cliente = new Cliente(nome,documento,email,command.Telefone);

            var   _mouse = new Produto("mouse","mouse","_mouse",15,2);
            var   _teclado = new Produto("_teclado","_teclado","_teclado",15,2);
            var   _monitor = new Produto("_monitor","_monitor","_monitor",15,2);

            return Ok();
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult Put([FromBody]Cliente  cliente){
            return Ok();
        }
    }
}