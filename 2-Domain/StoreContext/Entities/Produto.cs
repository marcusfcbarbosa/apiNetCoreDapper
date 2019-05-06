using System;
using FluentValidator;


namespace _2_Domain.StoreContext.Entities
{
    public class Produto : Notifiable
    {
        public Produto(string titulo, string descricao,string imagem,decimal preco, int qtd){
                Titulo = titulo;
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
                if(qtd> Quantidade){
                    AddNotification("Quantidade","Produto indisponivel no estoque");
                }
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