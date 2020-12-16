using System;

namespace ex2.classe
{
    public class Produto
    {
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque {get;set;}

        //metodo construtor obrigatoriamente tem o mesmo nome da classe
        public Produto(){

        }

        //metodo construtor
        public Produto(int codigo){
            Codigo = codigo;
            Console.WriteLine($"Codigo inserido foi {Codigo}");
        }

        public Produto (int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

            
        }
    }
}