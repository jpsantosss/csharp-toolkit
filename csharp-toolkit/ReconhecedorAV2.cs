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
                Console.Write("Digite a cadeia sobre Σ={a,b} (vazio = ENTER): ");
                string? cadeia = Console.ReadLine();
                if (cadeia == null) cadeia = "";

                Console.Write("Limite de passos (ex: 100): ");
                if (!int.TryParse(Console.ReadLine(), out int limite)) limite = 100;

                int passos = 0;
                int contadorA = 0, contadorB = 0;
                bool comecouB = false;
                bool erro = false;

                // cadeia vazia => pertence à linguagem (n = 0)
                if (cadeia.Length == 0)
                {
                    Console.WriteLine("Reconhecida (cadeia vazia).");
                }
                else
                {
                    foreach (char c in cadeia)
                    {
                        if (c == 'a')
                        {
                            if (comecouB)
                            {
                                Console.WriteLine("Não reconhecida (um 'a' apareceu depois de 'b').");
                                erro = true;
                                break;
                            }
                            contadorA++;
                        }
                        else if (c == 'b')
                        {
                            comecouB = true;
                            contadorB++;
                        }
                        else
                        {
                            Console.WriteLine($"Símbolo inválido: '{c}'. Use apenas 'a' e 'b'.");
                            erro = true;
                            break;
                        }

                        passos++;
                        if (passos >= limite)
                        {
                            Console.WriteLine("Execução interrompida por limite de passos.");
                            erro = true;
                            break;
                        }
                    }

                    if (!erro)
                    {
                        if (contadorA == contadorB)
                            Console.WriteLine("Reconhecida");
                        else
                            Console.WriteLine($"Não reconhecida (quantidade de 'a' = {contadorA}, 'b' = {contadorB}).");
                    }
                }

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
