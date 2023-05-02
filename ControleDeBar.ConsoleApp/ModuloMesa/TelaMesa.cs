using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        private RepositorioMesa repositorioMesa;
        private TelaConta telaConta;
        private RepositorioConta repositorioConta;

        public TelaMesa(RepositorioMesa repositorioMesa, TelaConta telaConta, RepositorioConta repositorioConta)
        {
            
            this.repositorioConta = repositorioConta;
            this.telaConta = telaConta;
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Mesa", "Ocupada", "Conta até o Momento");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", mesa.id, mesa.localidade, mesa.ocupada, mesa.conta);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Conta conta = ObterConta();
            Console.WriteLine("Insira o número da Mesa: ");
            int localidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira se a mesa está ocupada ou não: ");
            string ocupada = Console.ReadLine();
            
            return new Mesa(localidade, ocupada, conta);


        }
        private Conta ObterConta()
        {
           
            telaConta.VisualizarRegistros(false);
            Conta conta = (Conta)telaConta.EncontrarRegistro("Digite o id da Conta: ");

            

            Console.WriteLine();

            return conta;
        }
    }
}
