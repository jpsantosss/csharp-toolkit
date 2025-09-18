using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_toolkit
{
    internal class Alfabeto
    {
        public Alfabeto() { }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Digite uma cadeia de caracteres composta apenas por 'a' e 'b':");
                string? cadeia = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadeia) && cadeia.All(c => c == 'a' || c == 'b'))
                {
                    Console.WriteLine($"A cadeia '{cadeia}' é válida no alfabeto Σ = {{a, b}}.");
                }
                else
                {
                    Console.WriteLine($"A cadeia '{cadeia}' contém caracteres inválidos para o alfabeto Σ = {{a, b}}.");
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
