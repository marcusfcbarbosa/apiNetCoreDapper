using System;
using _4_Shared.Enum;
using _4_Shared.ValudeObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace _4_Shared.ValudeObjects
{
    public class Documento  : Notifiable
    {
        public Documento(string number, EnumDocumentType type){
            switch (type)
            {
                case EnumDocumentType.CNPJ:
                    
                    AddNotifications(new ValidationContract()
                            .Requires()
                            .HasLen(number, 14, "Document.Number", "Cnpj deve possuir 14 caracteres")
                    );
                    AddNotifications(new ValidationContract()
                            .Requires()
                            .IsTrue(IsCnpj(number), "Document.Number", "CNPJ Inválido")
                    );
                    break;

                case EnumDocumentType.CPF:

                    AddNotifications(new ValidationContract()
                            .Requires()
                            .HasLen(number, 11, "Document.Number", "CPF deve possuir 11 caracteres")
                    );
                    AddNotifications(new ValidationContract()
                            .Requires()
                            .IsTrue(IsCpf(number), "Document.Number", "CPF Inválido")
                    );
                    break;
            }
            Number = number;
            Type = type;
        }
        public string Number { get; private set; }
        public EnumDocumentType Type { get; private set; }
        public bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}