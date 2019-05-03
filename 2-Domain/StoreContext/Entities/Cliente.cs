using System;

namespace _2_Domain.StoreContext.Entities{
    public class Cliente
    {
        public Cliente(string nome, string sobrenome,
        string documento,string email,string telefone,
         string endereco){
                Nome = nome;
                Sobrenome = sobrenome;
                Documento = documento;
                Email = email;
                Telefone = telefone;
                Endereco = endereco;
        }
        public String Nome { get; private set; }
        public String Sobrenome { get; private set; }
        public String Documento { get; private set; }
        public String Email { get; private set; }
        public String Telefone { get; private set; }
        public String Endereco { get; private set; }

        public override string ToString(){
            return $"{Nome} {Sobrenome}";
        }
    }
}