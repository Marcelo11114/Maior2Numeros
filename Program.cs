using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
             int A=0, B=0;
            String Sair="";  
            do
            {    

            Console.Clear();
                      

            Console.WriteLine("+---------------------+");
            Console.WriteLine("| Qual o numero maior |");
            Console.WriteLine("+---------------------+\n");

            Console.Write("Entre com o 1º numero: ");
            A=Convert.ToInt32(Console.ReadLine());
      
            
            Console.Write("Entre com o 2º numero: ");
            B=Convert.ToInt32(Console.ReadLine());
                       

           

            if (A>B) { Console.WriteLine($"{A} é maior que {B}"); }
              else 
                 if (A<B){ Console.WriteLine($"{B} é maior que {A}");}
            if (A==B) {Console.WriteLine($"   {A} e {B} são iguais\n");}

            Console.Write("Outro (s)?");
            Sair = Console.ReadLine().ToUpper();
            } while(Sair == "S");
           
          
           
        }
    
    }
}
