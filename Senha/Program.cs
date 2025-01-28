namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // senha correta
            string senhadigitada; // senha digitada pelo usuário
            int tentativas = 0; // contador de tantativas
            do
            {
                Console.Clear();
                Console.Write("Digite a senha");
                senhadigitada = Console.ReadLine();
                tentativas++;

                if (senhadigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("voce tem ainda " + (3 - tentativas) + "tentativa (s)");
                    Console.ReadKey();
                }
                else if(senhadigitada != senha && tentativas ==3)
                {
                    Console.WriteLine("senha incorreta! Seu acesso está bloqueado!");
                    return;
                }
            } while (senhadigitada != senha);

            Console.Clear() ;
            Console.WriteLine("Senha correta! - Tentativas " + tentativas);
        }
    }
}
