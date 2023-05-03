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
        

        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            
            
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Mesa", "Ocupada");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", mesa.id, mesa.localidade, mesa.ocupada);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Insira o número da Mesa: ");
            int localidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira se a mesa está ocupada ou não: ");
            string ocupada = Console.ReadLine();
            
            return new Mesa(localidade, ocupada);


        }
        
    }
}
