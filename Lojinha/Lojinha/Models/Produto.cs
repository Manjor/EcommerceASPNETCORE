using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class Produto
    {

        public int Id { get;  set; }
        public string NomeProduto { get;  set; }
        public string Descricao { get; set; }
        public int Quantidade { get;  set; }
        public decimal Valor { get;  set; }
        public string Arquivo { get; set; }
        public Categoria Categoria { get; set; }



        //Construtor com Id
        public Produto(int id, string nomeproduto, string descricao, int quantidade, decimal valor, string arquivo, Categoria categoria)
            : this(nomeproduto,descricao,quantidade,valor,arquivo,categoria)
        {

            this.Id = id;
        }

        //Construtor de Adicionar
        public Produto(string nomeproduto,string descricao, int quantidade, decimal valor, string arquivo, Categoria categoria)
        {
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Valor = valor;
            this.Arquivo = arquivo;
            this.Categoria = categoria;
        }

        public Produto() { }

        /*
         https://msdn.microsoft.com/pt-br/library/jj128159.aspx
         https://www.devmedia.com.br/linq-e-c-efetuando-consultas-com-lambda-expressions/38863
         https://pt.stackoverflow.com/questions/87528/fazer-consultas-usando-o-entity-framework
         http://www.macoratti.net/14/10/ef6_qry1.htm
         https://social.msdn.microsoft.com/Forums/pt-BR/bcae3b3a-4c95-4b83-842a-7e29e1f1c793/inserir-dados-em-multiplias-tabelas-com-chave-estrangeira-pelo-mvc-no-c?forum=vscsharppt
         http://www.tiselvagem.com.br/desenvolvimento/chave-estrangeira-e-associacao-independente-no-entity-framework/
         http://www.tiselvagem.com.br/desenvolvimento/chave-estrangeira-e-associacao-independente-no-entity-framework/
         
         */

    }
}
