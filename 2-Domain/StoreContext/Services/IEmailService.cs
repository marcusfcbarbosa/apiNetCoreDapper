namespace _2_Domain.StoreContext.Services
{
    public interface IEmailService
    {
         void EnviaEmail(string para, string de, string assunto, string mensagem);
    }
}