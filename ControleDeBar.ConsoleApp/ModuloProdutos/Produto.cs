using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class Produto : EntidadeBase
    {
        public string nome;
        public string tipo;
        public int preco;

        public Produto (string nome, string tipo, int preco)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.tipo = produtoAtualizado.tipo;
            this.preco = produtoAtualizado.preco;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (nome.Length <= 3)
                erros.Add("O campo \"nome\" precisa ter mais que 3 letras");

            if (string.IsNullOrEmpty(tipo.Trim()))
                erros.Add("O campo \"tipo\" é obrigatório");
            if (preco < 0)
                erros.Add("O campo \"preco\" não pode ser menor que 0");




            return erros;
        }
    }
}
