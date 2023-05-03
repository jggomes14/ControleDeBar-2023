using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarçom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Produto produto;

        public Garcom garcom;
        public string estaAberto;
        public Mesa mesa;


        public Conta (Produto produto, Garcom garcom, string estaAberto, Mesa mesa)
        {
            this.produto = produto;
            this.garcom = garcom;
            this.estaAberto = estaAberto;
            this.mesa = mesa;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;
            this.produto = contaAtualizada.produto;
            this.garcom = contaAtualizada.garcom;
            this.mesa = contaAtualizada.mesa;

        }
       


        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (produto == null)
                erros.Add("O campo \"produto\" é obrigatório");
            if (garcom == null)
                erros.Add("O campo \"garcom\" é obrigatório");
            return erros;
        }
    }
}
