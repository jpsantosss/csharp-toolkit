using System;

namespace csharp_toolkit
{
    internal class Decisores
    {
        public Decisores() { }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== Item 2 — Decisores ===");
                Console.WriteLine("1. L_fim_b (cadeias que terminam com 'b')");
                Console.WriteLine("2. L_mult3_b (número de 'b' múltiplo de 3)");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();
                Console.Write("Digite a cadeia sobre Σ={a,b}: ");
                string cadeia = Console.ReadLine();
                if (!Validar(cadeia))
                {
                    Console.WriteLine("Cadeia inválida (somente 'a' e 'b').");
                    return;
                }
                bool aceita = opcao switch
                {
                    "1" => cadeia.EndsWith('b'),
                    "2" => ((cadeia.Split('b').Length - 1) % 3 == 0),
                    _ => false
                };
                Console.WriteLine(aceita ? "SIM" : "NÃO");

                static bool Validar(string cadeia)
                {
                    foreach (char c in cadeia)
                        if (c != 'a' && c != 'b') return false;
                    return true;
                }
                // Pergunta se o usuário deseja testar outra cadeia
                Console.WriteLine("\nDeseja testar novamente? (S/N)");
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
