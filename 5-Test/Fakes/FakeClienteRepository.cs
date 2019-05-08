using System.Collections.Generic;
using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Queries;
using _2_Domain.StoreContext.Repositories.Interfaces;

namespace _5_Test.Fakes
{
    public class FakeClienteRepository //: IClienteRepository
    {

        public FakeClienteRepository()
        {

        }

        public bool CheckaDocumento(string documento)
        {
            return false;
        }

        public bool checkaEmail(string email)
        {
            return false;
        }

        public IEnumerable<ListaClientesQueryResults> Get()
        {
            throw new System.NotImplementedException();
        }

        public ContadorPedidosCliente RetornaPedidosCliente(string documento)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            
        }

        
    }
}