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
       

        public Mesa (int localidade, string ocupada)
        {
            this.localidade = localidade;
            this.ocupada = ocupada;
            
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;
            this.localidade = mesaAtualizada.localidade;
            this.ocupada = mesaAtualizada.ocupada;
            

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (localidade < 0)
                erros.Add("O campo \"localidade\" não pode ser menor que 0");
           



            return erros;
        }
    }
}
