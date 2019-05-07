using _2_Domain.StoreContext.Entities;
using _2_Domain.StoreContext.Repositories.Interfaces;

namespace _5_Test.Fakes
{
    public class FakeClienteRepository : IClienteRepository
    {

        public bool CheckaDocumento(string documento)
        {
            return false;
        }

        public bool checkaEmail(string email)
        {
            return false;
        }

        public void Save(Cliente cliente)
        {
            
        }
    }
}