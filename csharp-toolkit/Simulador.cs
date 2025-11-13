using System;

namespace csharp_toolkit
{
    internal class Simulador
    {
        public Simulador() { }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== Item 10 ===");

                Console.WriteLine("AFD: L = { w | w termina com 'ab' }");
                Console.Write("Digite cadeia sobre Σ={a,b}: ");
                string cadeia = Console.ReadLine();
                var estados = new Dictionary<string, Dictionary<char, string>>
                {
                    ["q0"] = new() { ['a'] = "q1", ['b'] = "q0" },
                    ["q1"] = new() { ['a'] = "q1", ['b'] = "q2" },
                    ["q2"] = new() { ['a'] = "q1", ['b'] = "q0" }
                };
                string estado = "q0";
                foreach (char c in cadeia)
                {
                    if (!estados[estado].ContainsKey(c))
                    {
                        Console.WriteLine($"Símbolo inválido: {c}");
                        return;
                    }
                    estado = estados[estado][c];
                    Console.WriteLine($"Consumiu '{c}' → Estado atual: {estado}");
                }
                Console.WriteLine(estado == "q2" ? "ACEITA" : "REJEITA");

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
