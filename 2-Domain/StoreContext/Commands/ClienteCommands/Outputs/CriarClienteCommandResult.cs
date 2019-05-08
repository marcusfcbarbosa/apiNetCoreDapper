using System;
using _4_Shared.Commands;

namespace _2_Domain.StoreContext.Commands.ClienteCommands.Outputs
{
    public class CriarClienteCommandResult : ICommandResult
    {
        public CriarClienteCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success {  get;  set;}
        public string Message {  get;  set; }
        public object Data {  get;  set; }
    }
}