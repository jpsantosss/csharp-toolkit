using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_toolkit
{
    internal class Decisor
    {
        public Decisor() { }
        public void Show() 
        {
            while(true){
                Console.WriteLine("Digite uma cadeia para verificar se ela termina em 'b'");
                string? cadeia = Console.ReadLine();

                if (string.IsNullOrEmpty(cadeia))
                {
                    Console.WriteLine("NAO");
                }
                else
                {
                    char ultimo = cadeia[^1];
                    if (ultimo == 'b')
                        Console.WriteLine("SIM");
                    else
                        Console.WriteLine("NAO");
                }
                Console.WriteLine("\nDeseja testar outra cadeia? (S/N)");
                string? resposta = Console.ReadLine();

                if (resposta == null || resposta.Trim().ToUpper() != "S")
                {
                    Console.WriteLine("Voltando ao menu...");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
