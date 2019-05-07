using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Repositories.Interfaces;

namespace _5_Test.Fakes
{
    public class FakeClienteRepository : IClienteRepository
    {
        
        public bool CheckaDocumento(string documento)
        {
            throw new System.NotImplementedException();
        }

        public bool checkaEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}