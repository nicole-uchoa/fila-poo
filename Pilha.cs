using System;
using System.Collections.Generic;



namespace testePilha
{
    class Pilha
    {
        public Stack<int> inteiros = new Stack<int>();
        public Stack<int> inteirosAux = new Stack<int>();

        public void InserirElemento(int itemAdd)
        {
            inteiros.Push(itemAdd);
        }

        public void ExluirElemento()
        {
            if (inteiros.Count != 0)
            {
                int excluido = inteiros.Pop();
                Console.WriteLine("Elemento excluido: {0}", excluido);
            }
            else
            {
                Console.WriteLine("Pilha vazia.");
            }
        }

        public int MaiorElemento()
        {
            int aux = inteiros.Peek();
            for (int i = inteiros.Count; i > 0; i--)
            {
                int ultElemento = inteiros.Pop();
                // Guardar os valores da pilha em uma pilha auxiliar
                inteirosAux.Push(ultElemento);
                if (ultElemento >= aux)
                {
                    aux = ultElemento;
                }
            }
            // retomar a pilha original e utiliza-la em outras funções sem comprometer o programa
            while (inteirosAux.Count != 0)
            {
                inteiros.Push(inteirosAux.Pop());
            }
            return aux;
        }
        public int MenorElemento()
        {
            int menorNum = inteiros.Peek();
            int tamPilha = inteiros.Count;
            for (int I = 0; I < tamPilha; I++)
            {
                int ultimoElemento = inteiros.Pop();
                // Guardar os valores da pilha em uma pilha auxiliar
                inteirosAux.Push(ultimoElemento);
                if (ultimoElemento <= menorNum)
                {
                    menorNum = ultimoElemento;
                }
            }
            // retomar a pilha original e utiliza-la em outras funções sem comprometer o programa
            while (inteirosAux.Count != 0)
            {
                inteiros.Push(inteirosAux.Pop());
            }
            return menorNum;
        }

        public string MostrarPilha()
        {
            string aux = "";
            foreach (int item in inteiros)
            {
                aux = aux.Insert(0, item.ToString() + " ");

            }
            return aux;
        }
    }
}