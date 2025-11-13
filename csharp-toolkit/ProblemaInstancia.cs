using System;
using System.Text.Json;

namespace csharp_toolkit
{
    internal class ProblemaInstancia
    {
        public ProblemaInstancia() { }
        public void Show()
        {
            // Loop para permitir múltiplos testes
            while (true)
            {

                string json = System.IO.File.ReadAllText(@"dados\problemas_instancias.json");
                var itens = JsonSerializer.Deserialize<Item[]>(json);
                int acertos = 0;
                Console.WriteLine("\n=== Item 6 ===");
                foreach (var item in itens)
                {
                    Console.WriteLine($"\nFrase: {item.texto}");
                    Console.Write("É (P)roblema ou (I)nstância? ");
                    string answer = Console.ReadLine()?.Trim().ToUpper();
                    if (answer == item.tipo) acertos++;
                }
                Console.WriteLine($"\nAcertos: {acertos}/{itens.Length}");

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

        class Item
        {
            public string texto { get; set; }
            public string tipo { get; set; }
        }


    }
}
