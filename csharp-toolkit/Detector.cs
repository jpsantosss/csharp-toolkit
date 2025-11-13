using System;

namespace csharp_toolkit
{
    internal class Detector
    {
        public Detector() { }
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== Item 4 — Detector de Loop + Reflexão ===");
                HashSet<int> estados = new();
                int estado = 1;
                int limite = 20;
                for (int i = 0; i < limite; i++)
                {
                    if (estados.Contains(estado))
                    {
                        Console.WriteLine($"Loop detectado no estado {estado} no passo {i}.");
                        break;
                    }
                    estados.Add(estado);
                    estado = (estado * 2 + 3) % 5;
                    Console.WriteLine($"Passo {i}: estado = {estado}");
                }
                Console.WriteLine("\nReflexão: o método pode gerar falsos positivos ou negativos dependendo dos estados armazenados.");
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
