using System;

namespace csharp_toolkit
{
    internal class ReconhecedorAV2
    {
        public ReconhecedorAV2() { }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== Item 3 — Reconhecedor ===");
                Console.WriteLine("Linguagem: { a^n b^n | n ≥ 0 }");
                Console.Write("Digite a cadeia sobre Σ={a,b}: ");
                string cadeia = Console.ReadLine();
                Console.Write("Limite de passos (ex: 100): ");
                if (!int.TryParse(Console.ReadLine(), out int limite)) limite = 100;
                int passos = 0;
                int contadorA = 0, contadorB = 0;
                foreach (char c in cadeia)
                {
                    if (c == 'a') contadorA++;
                    else if (c == 'b') contadorB++;
                    else { Console.WriteLine("Símbolo inválido."); return; }
                    passos++;
                    if (passos >= limite)
                    {
                        Console.WriteLine("Execução interrompida por limite de passos.");
                        return;
                    }
                }
                Console.WriteLine(contadorA == contadorB ? "Reconhecida" : "Não reconhecida");
                // Pergunta se o usuário deseja testar novamente
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
