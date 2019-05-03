using System;

namespace _2_Domain.StoreContext.Entities
{
    public class Produto
    {
        public Produto(string titulo, string descricao,string imagem,decimal preco,int qtd){
                
                Titulo = titulo;
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
                Quantidade = qtd;
        }
        public String Titulo { get; private set; }
        public String Descricao { get; private set; }
        public String Imagem { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }

        public override string ToString(){
            return Titulo;
        }
    }
}