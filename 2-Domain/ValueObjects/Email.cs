using System;
using _4_Shared.ValudeObjects;
using Flunt.Validations;

namespace _2_Domain.ValueObjects
{
    public class Email : ValueObject
    {
         public Email(string address)
        {
            Address = address;
            AddNotifications(new Contract()
            .Requires()
            .IsEmail(Address, "Email.Address", "E-mail inválido")
            );
        }
        public String Address { get; private set; }
    }
}