using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarçom
{
    internal class TelaGarcom : TelaBase
    {
        private RepositorioGarcom repositorioGarcom;
        private TelaMesa telaMesa;
        private RepositorioMesa repositorioMesa;
        public TelaGarcom(RepositorioGarcom repositorioGarcom, RepositorioMesa repositorioMesa, TelaMesa telaMesa)
        {
            this.repositorioMesa = repositorioMesa;
            this.telaMesa = telaMesa;
            this.repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
            sufixo = "(ns)";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Mesa Atendida");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcom garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", garcom.id, garcom.nome, garcom.mesa);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Mesa mesa = ObterMesa();
            Console.WriteLine("Insira o nome do Garçom: ");
            string nome = Console.ReadLine();

            return new Garcom(nome, mesa);
        }
        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id da Mesa: ");



            Console.WriteLine();

            return mesa;
        }
    }
}
