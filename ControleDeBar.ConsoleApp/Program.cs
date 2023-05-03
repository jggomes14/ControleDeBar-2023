using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarçom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom, repositorioMesa, telaMesa);
            TelaConta telaConta = new TelaConta(repositorioConta, repositorioMesa, telaMesa, repositorioProduto, telaProduto, repositorioGarcom, telaGarcom);
            TelaPrincipal principal = new TelaPrincipal();
            while (true)
            {
                string opcao = principal.ApresentarMenu();

                if (opcao == "0")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }
                else if (opcao == "4")
                {
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirMultiplosRegistros();
                    }
                    else if (subMenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaConta.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaConta.ExcluirRegistro();
                    }
                 
                }

            }
        }
    }
}