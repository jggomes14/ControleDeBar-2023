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
    public class Garcom : EntidadeBase
    {
        public string nome;
        public Mesa mesa;

        public Garcom (string nome, Mesa mesa)
        {
            this.nome = nome;
            this.mesa = mesa;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;
            this.nome = garcomAtualizado.nome;
            this.mesa = garcomAtualizado.mesa;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (nome.Length <= 3)
                erros.Add("O campo \"nome\" precisa ter mais que 3 letras");
            if (mesa == null)
                erros.Add("O campo \"mesa\" é obrigatório");



            return erros;
        }
    }
}
