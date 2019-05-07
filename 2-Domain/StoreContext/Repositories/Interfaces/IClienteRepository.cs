using _2_Domain.StoreContext.Entities;

namespace _2_Domain.StoreContext.Repositories.Interfaces
{
    public interface IClienteRepository
    {
         bool CheckaDocumento(string documento);
         bool checkaEmail(string email);
         void Save(Cliente cliente);
    }
}