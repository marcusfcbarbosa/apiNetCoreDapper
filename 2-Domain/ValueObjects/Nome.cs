using System;

namespace _2_Domain.ValueObjects
{
    public class Nome
    {
        public Nome(string primeiroNome, string sobrenome){
                PrimeiroNome = primeiroNome;
                Sobrenome = sobrenome;
        }

        public String PrimeiroNome { get; private set; }
        public String Sobrenome { get; private set; }
        
    }
}