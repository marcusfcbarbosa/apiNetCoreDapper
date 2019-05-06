
using _4_Shared.Enum;
using FluentValidator;

namespace _2_Domain.StoreContext.Entities
{
    public class Endereco : Notifiable
    {
        public Endereco(string rua,
        string numero,
        string complemento
        ,string bairro,
        string cidade,
        string estado 
        ,string pais,
        string cep, TipoEndereco tipoEndereco){
                Rua = rua;
                Numero = numero;
                Complemento = complemento;
                Bairro = bairro;
                Cidade = cidade;
                Estado =estado;
                Pais = pais;
                Cep = cep;
                TipoEndereco = tipoEndereco;
        }
        
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }
        public TipoEndereco TipoEndereco { get; private set; }

        public override string ToString(){
            return "${Rua}, {Numero} - {Cidade}/{Estado}";
        }
    }
}