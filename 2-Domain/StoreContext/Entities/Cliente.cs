using System;
using System.Linq;
using _2_Domain.ValueObjects;
using System.Collections.Generic;

namespace _2_Domain.StoreContext.Entities
{
    public class Cliente
    {
        private readonly IList<Endereco> _enderecos;
        public Cliente(Nome nome,
            Documento documento, 
            Email email, 
            string telefone)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            _enderecos = new List<Endereco>();
            
        }
       
        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public String Telefone { get; private set; }
        
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray();
        public void AdicionaEndereco(Endereco endereco){
                
                this._enderecos.Add(endereco);
        }

        public override string ToString(){
            return $"{Nome.PrimeiroNome}  {Nome.Sobrenome}";
        }
    }
}
