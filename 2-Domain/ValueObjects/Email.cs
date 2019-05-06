using System;
using _4_Shared.ValudeObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace _2_Domain.ValueObjects
{
    public class Email : Notifiable
    {
         public Email(string address)
        {
            Address = address;
            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail inválido")
                );
        }
        public String Address { get; private set; }
    }
}