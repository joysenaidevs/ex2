using System;
using ex2.classe;

namespace ex2
{
    class Program : Produto
    {
        static void Main(string[] args)
        {
          //utilizando construtor vazio

          Produto produto1 = new Produto ();

          produto1.Codigo = 1;
          produto1.Nome = "Coca-Cola";
          produto1.Descricao = "Refrigerante";
          produto1.Estoque = 30;
          Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descricao {produto1.Descricao}, Estoque {produto1.Estoque}");

          //Construtor inserindo apenas o codigo

          Produto produto2 = new Produto(10);
          produto2.Nome = "Pepsi";
          Console.WriteLine($"Codigo inserido {produto2.Codigo}, nome {produto2.Nome}");

          //Construtor inserindo todos os valores

          Produto produto3 = new Produto(1, "trakinas", "Bolacha de chocolate", 1000);

          Console.WriteLine($"O codigo inserido {produto3.Codigo}, {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");

          


        }
    }
}
