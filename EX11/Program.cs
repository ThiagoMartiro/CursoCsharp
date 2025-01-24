namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabudada;
            Console.WriteLine("Digite um número");
            tabudada = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", tabudada, i, tabudada * i);
            }
        }
    }
}
