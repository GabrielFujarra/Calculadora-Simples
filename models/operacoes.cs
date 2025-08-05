using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class Operacoes
    {
        private int numero1;
        private int numero2;
        

        public Operacoes(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int Soma()
        {
            int resultadoSoma = numero1 + numero2;
            return resultadoSoma;
        }

        public int Subtracao()
        {
            int resultadoSubtracao = numero1 - numero2;
            return resultadoSubtracao;
        }

        public int Multiplicacao()
        {
            int resultadoMultiplicacao = numero1 * numero2;
            return resultadoMultiplicacao;
        }

        public double Divisao()
        {
            int resultadoDivisao = numero1 / numero2;
            return resultadoDivisao;
        }
    }
}