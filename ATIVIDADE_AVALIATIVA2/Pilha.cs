using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_AVALIATIVA2
{
    class Pilha
    {
        private int[] valores;
        private int topo = 0;

        public Pilha(int maximo)
        {
            this.valores = new int[maximo];
        }

        public void empilhar(int valor)
        {
            if (!cheia())
            {
                valores[topo] = valor;
                topo++;
            }
            else
            {
                Console.WriteLine("Erro: Pilha Cheia :/");
            }

        }

        public int? desempilhar()
        {
            if (!vazia())
            {
                topo--;
                return valores[topo];
            }
            return null;
        }

        public bool vazia()
        {
            return this.topo == 0;
        }

        public bool cheia()
        {
            return this.topo == valores.Length;
        }

        public int? somar()
        {
            int? valor1 = desempilhar();
            int? valor2 = desempilhar();
            if (valor1 != null && valor2 != null)
            {
                return valor1 + valor2;
            }
            return null;
        }

        public int? subtrair()
        {
            int? valor1 = desempilhar();
            int? valor2 = desempilhar();
            if (valor1 != null && valor2 != null)
            {
                return valor1 - valor2;
            }
            return null;
        }

        public int? multiplicar()
        {
            int? valor1 = desempilhar();
            int? valor2 = desempilhar();
            if (valor1 != null && valor2 != null)
            {
                return valor1 * valor2;
            }
            return null;
        }

        public int? divisao()
        {
            int? valor1 = desempilhar();
            int? valor2 = desempilhar();
            if (valor1 != null && valor2 != null)
            {
                return valor1 / valor2;
            }
            return null;
        }

        public void imprimirPilha()
        {
            Console.WriteLine("[ {0} ]", string.Join(", ", valores[0..this.topo]));
        }
    }
}
