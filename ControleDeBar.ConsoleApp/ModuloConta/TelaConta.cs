﻿using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarçom;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaConta : TelaBase
    {
        private RepositorioGarcom repositorioGarcom;
        private TelaProduto telaProduto;
        private RepositorioProduto repositorioProduto;
        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private RepositorioMesa repositorioMesa;
        public TelaConta(RepositorioConta repositorioConta, RepositorioMesa repositorioMesa, TelaMesa telaMesa, RepositorioProduto repositorioProduto, TelaProduto telaProduto, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom)
        {
            this.repositorioMesa = repositorioMesa;
            this.telaMesa = telaMesa;
            this.repositorioProduto = repositorioProduto;
            this.telaProduto = telaProduto;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.repositorioBase = repositorioConta;
            nomeEntidade = "Conta";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}", "Id", "Nome", "Tipo", "Preço", "Aberta");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Conta conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -20}", conta.id, conta.garcom.nome, conta.produto.nome, conta.produto.preco + "reais", conta.estaAberto);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Mesa mesa = ObterMesa();
            Garcom garcom = ObterGarcom();
            Produto produto = ObterProduto();
            string estaAberto = null;
            return new Conta(produto, garcom, estaAberto, mesa) ;
        }
        private Garcom ObterGarcom()
        {

            telaGarcom.VisualizarRegistros(false);
            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");



            Console.WriteLine();

            return garcom;
        }
        private Produto ObterProduto()
        {

            telaProduto.VisualizarRegistros(false);
            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do Produto: ");



            Console.WriteLine();

            return produto;
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
