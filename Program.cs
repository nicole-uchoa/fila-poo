using System;

namespace testePilha
{
    class Program
    {
        static void Main(string[] args)
        {

            Fila f = new Fila();
    
            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1- Inserir inteiro na fila.");
                Console.WriteLine("2- Excluir inteiro da fila.");
                Console.WriteLine("3- Inserir inteiro após outro a ser escolhido.");
                Console.WriteLine("4- Reverter fila.");
                Console.WriteLine("5- Imprimir fila.");
                Console.WriteLine("6 - Sair.");

                string menu = Console.ReadLine();
                
                switch (menu)
                {
                    case "1":
                        Console.Write("Digite o inteiro a ser inserido: ");
                        int inteiroInserido = Convert.ToInt32(Console.ReadLine());
                        f.IncluirElemento(inteiroInserido);
                        Console.WriteLine(inteiroInserido);
                        Console.Clear();
                        break;
                    case "2":
                        f.RemoverElemento();
                        break;
                    case "3":
                        Console.WriteLine("Insira o inteiro a ser inserido");
                        int incluir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insira o inteiro que deve anteceder o inteiro inserido");
                        int antecessor = Convert.ToInt32(Console.ReadLine());
                        f.InserirAposOutro(incluir, antecessor);
                        break;
                    case "4":
                        f.Reverter();
                        break;
                    case "5":
                        f.Imprimir();
                        break;
                    case "6":
                        aux = 1;
                        break;
                    default:
                        Console.WriteLine("Favor escolher uma das opções listadas.");
                        break;
                }
            }

        }
    }
}
