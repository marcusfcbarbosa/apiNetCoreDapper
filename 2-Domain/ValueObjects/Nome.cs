using System;
using _4_Shared.ValudeObjects;


namespace _2_Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobrenome){
                PrimeiroNome = primeiroNome;
                Sobrenome = sobrenome;
        }

        public String PrimeiroNome { get; private set; }
        public String Sobrenome { get; private set; }
        

        public override string ToString(){
            return $"{PrimeiroNome}  {Sobrenome}";
        }
    }
}