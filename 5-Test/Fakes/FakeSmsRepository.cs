using _2_Domain.StoreContext.Services.Interfaces;

namespace _5_Test.Fakes
{

    public class FakeSmsRepository : IEmailService
    {
        public void EnviaEmail(string para, string de, string assunto, string mensagem)
        {
            throw new System.NotImplementedException();
        }
    }
}