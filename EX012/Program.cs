namespace EX012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opção = 0;

            Console.Write("Digite o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opção !=5)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - somar ");
                Console.WriteLine("2 - subtrair ");
                Console.WriteLine("3 - multiplicar ");
                Console.WriteLine("4 - number news ");
                Console.WriteLine("5 - sair ");
                opção = Convert.ToInt32(Console.ReadLine());

                switch (opção)
                {
                    case 1: n3=n1+ n2;
                        Console.WriteLine("A Soma de {0} + {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 2:
                        n3 = n1 - n2;
                        Console.WriteLine("A Subtração de {0} - {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 3:
                        n3 = n1 * n2;
                        Console.WriteLine("A multiplicar de {0} * {1} é igual a {2}.", n1, n2, n3);
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número:");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o segundo número:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }
        }
            
            
    }
}
