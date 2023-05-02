using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Nome", "Tipo", "Preço");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", produto.id, produto.nome, produto.tipo, produto.preco + "reais");
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
           Console.WriteLine("Insira o nome do Produto: ");
           string nome = Console.ReadLine();
           Console.WriteLine("Insira o tipo do Produto (Bebida/Comida)");
           string tipo = Console.ReadLine();
           Console.WriteLine("Confirme o Preço do Produto: ");
           int preco = int.Parse(Console.ReadLine());
           return new Produto (nome, tipo, preco);
        }
    }
}
