using System;

namespace _2_Domain.StoreContext
{
    public class Cliente
    {
        public String Nome { get; private set; }
        public String Sobrenome { get; private set; }
        public String Documento { get; private set; }
        public String Email { get; private set; }
        public String Telefone { get; private set; }
        public String Endereco { get; private set; }
    }
}