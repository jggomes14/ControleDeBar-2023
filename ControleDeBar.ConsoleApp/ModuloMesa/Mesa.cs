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
    public class Mesa : EntidadeBase
    {
       public int localidade;
       public string ocupada;
       public Conta conta;

        public Mesa (int localidade, string ocupada, Conta conta)
        {
            this.localidade = localidade;
            this.ocupada = ocupada;
            this.conta = conta;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;
            this.localidade = mesaAtualizada.localidade;
            this.ocupada = mesaAtualizada.ocupada;
            this.conta = mesaAtualizada.conta;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (localidade < 0)
                erros.Add("O campo \"localidade\" não pode ser menor que 0");
            if (conta == null)
                erros.Add("O campo \"conta\" é obrigatório");



            return erros;
        }
    }
}
