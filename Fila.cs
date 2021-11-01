using System.Collections.Generic;
using System;

namespace testePilha
{
    public class Fila
    {
        Queue<int> fila = new Queue<int>();
        Queue<int> filaAuxiliar = new Queue<int>();


        public void IncluirElemento(int incluir)
        {
            fila.Enqueue(incluir);
            Console.WriteLine("\nInteiro inserido: {0}", incluir);
        }

        public void RemoverElemento()
        {
            if(fila.Count != 0)
            {
                int removido = fila.Dequeue();
                Console.WriteLine("\nInteiro removido: {0}", removido);
            }
            else{
                Console.WriteLine("\nLista Vazia");

            }

        }

        public void InserirAposOutro(int inserir, int apos)
        {
            int[] filaArr = fila.ToArray();
            int[] filaAux = new int[fila.Count + 1];

            for (int i = 0; i <= fila.Count - 1; i++)
            {
                if (filaArr[i] == apos)
                {
                    filaAux[i] = filaArr[i];
                    filaAux[i + 1] = inserir;
                }
                else
                {
                    filaAux[i] = filaArr[i];
                }
            }
            fila.Clear();
            for (int i = 0; i <= filaAux.Length - 1; i++)
            {
                fila.Enqueue(filaAux[i]);
            }

            Console.WriteLine("Nova fila: ");
            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }
        }

        public void Reverter()
        {
            int tamanhoFila = (fila.Count - 1);

            int[] filaReversa = new int[fila.Count];

            int[] filaArr = fila.ToArray();

            for (int j = 0; j <= tamanhoFila; j++)
            {
                filaReversa[j] = filaArr[tamanhoFila-j];
            }

            fila.Clear();
            for (int i = 0; i <= tamanhoFila; i++)
            {
                fila.Enqueue(filaReversa[i]);

            }

            Console.WriteLine("Fila reversa: ");
            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Fila: ");
            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

        }
    }
}