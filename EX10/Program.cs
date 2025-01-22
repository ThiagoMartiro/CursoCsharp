using System.ComponentModel.Design;

namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de salario");
            Double salario, salariofinal;
            Console.WriteLine("Quanto você recebe?");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                salariofinal = (salario * 0.05) + salario;
                Console.WriteLine("Seu aumento é de: {0}", salariofinal);
            }
            else if (salario > 1250)
            {
                salariofinal = (salario * 0.10) + salario;
                Console.WriteLine("O seu aumento é de:{0}", salariofinal);
            }
            else
            {
                salariofinal = (salario * 0.15) + salario;
                Console.WriteLine("O seu aumento é de:{0}", salariofinal);
            }
                
            
            

            
            
            
            

            
                
            
                
            
                  
                    

                

              
            
            
            
               
                
              
             
            

            


        }
    }
}
