using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            this.listaRegistros = listaConta;

        }
        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }
        public void Fechar()
        {
            Console.WriteLine("Qual a Conta que você quer fechar?");
            int id = int.Parse(Console.ReadLine());
            Conta conta = SelecionarPorId(id);

            if (conta != null)
            {
                if (conta.estaAberto != null)
                {
                    Console.WriteLine("Esta conta já foi fechada.");
                }
                else
                {
                    Console.WriteLine("Confirme se a conta está aberta:");
                    string taAberto = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(taAberto))
                    {
                        Console.WriteLine("Informação Inválida, a Conta permanece aberta.");
                    }
                    else
                    {
                        conta.estaAberto = taAberto;
                        Console.WriteLine("Conta Fechada com sucesso!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Empréstimo não encontrado!");
            }
        }
        public void RetornarValorTotalDasContasFechadas ()
        {

        }
    }
}
