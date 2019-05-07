using System;
using System.Linq;
using System.Data;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Repositories.Interfaces;
using _3_Infra.Context;
using Dapper;
using _2_Domain.StoreContext.Queries;

namespace _2_Domain.StoreContext.Repositories
{
    public class ClienteRepository :  IClienteRepository
    {
        private readonly Store_Context _context;
        public ClienteRepository(Store_Context context){
             _context = context;
        }

        public bool CheckaDocumento(string documento)
        {
               return   _context.
                        Connection
                        .Query<bool>("spCheckDocument",new { Documento = documento },
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public bool checkaEmail(string email)
        {
                return  _context.
                        Connection
                        .Query<bool>("spCheckEmail",
                        new { Email = email },
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public ContadorPedidosCliente RetornaPedidosCliente(string documento)
        {
             return   _context.
                        Connection
                        .Query<ContadorPedidosCliente>("spGetCustomerOrdersCount",new { Documento = documento },
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public void Save(Cliente cliente)
        {
            var t = _context.Connection.BeginTransaction();
            try{

                t.Connection
                        .Execute("spCreacteCustomer",
                        new { 
                            Id = cliente.Id,
                            PrimeiroNome = cliente.Nome.PrimeiroNome,
                            Sobrenome = cliente.Nome.Sobrenome,
                            Documento =cliente.Documento.Number,
                            Email = cliente.Email.Address,
                            Telefone= cliente.Telefone
                        },
                        commandType: CommandType.StoredProcedure);
                        t.Commit();
            }catch(System.Exception){
                t.Rollback();
            }finally{
                t.Dispose();
            }
        }
    }
}