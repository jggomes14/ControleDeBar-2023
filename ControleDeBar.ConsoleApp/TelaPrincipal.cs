using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp
{
    internal class TelaPrincipal
    {
        public string ApresentarMenu()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║         MENU PRINCIPAL           ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║ 1.  Gerenciar Produtos           ║");
            Console.WriteLine("║ 2.  Gerenciar Mesas              ║");
            Console.WriteLine("║ 3.  Gerenciar Garçons            ║");
            Console.WriteLine("║ 4.  Gerenciar Contas             ║");
            Console.WriteLine("║ 0.  Sair do programa             ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.Write("Digite a opção desejada: ");

            string opcao = Console.ReadLine();

            return opcao;



            
        } 
    }
}
