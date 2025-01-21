namespace EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler triângulo");

            int LadoA, LadoB, LadoC;
            Console.Write("Digite o valor do lado A:");
            LadoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B:");
            LadoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C:");
            LadoC = Convert.ToInt32(Console.ReadLine());

            if ((LadoA < LadoB + LadoC) && (LadoB < LadoA + LadoC) && (LadoC < LadoA + LadoB)) 
            {
                Console.WriteLine("Os valores informados formam um triângulo");
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo.");
            }


        }
    }
}
