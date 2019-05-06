using System;
using _4_Shared.ValudeObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace _4_Shared.ValudeObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string sobrenome){
                PrimeiroNome = primeiroNome;
                Sobrenome = sobrenome;
                
        }

        public void VerificaTamanho(string primeiroNome,string sobrenome){
            AddNotifications(new ValidationContract()
                    .Requires()
                    .HasMinLen(primeiroNome, 3,"PrimeiroNome","Nome deve conter pelo menos 3 caracteres")
                    );
        }
        public String PrimeiroNome { get; private set; }
        public String Sobrenome { get; private set; }
        

        public override string ToString(){
            return $"{PrimeiroNome}  {Sobrenome}";
        }
    }
}