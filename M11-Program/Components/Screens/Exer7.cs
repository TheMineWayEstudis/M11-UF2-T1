using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace M11_Program.Components.Screens
{
    class Exer7: IScreen
    {
        const string DEFAULT_NAME = "Olaf";
        const string DEFAULT_PASSWORD = "Count123";
        public void open()
        {
            Console.Clear();
            // Es carreguen les credencials simulades (per defecte Olaf i Count123)
            string name = UIBasics.readText($"Nom d'usuari ({DEFAULT_NAME})", DEFAULT_NAME);
            string password = UIBasics.readText($"Contrasenya ({DEFAULT_PASSWORD})", DEFAULT_PASSWORD);
            int delay = UIBasics.readNumber($"Delay (buit o 0 per deshabil·litar el delay)", 0);

            // Es carrega el fitxer de diccionari
            FileInfo file = UIBasics.getFile();
            if (file == null) return;

            // Llegim el contingut del fitxer
            string[] passwords = File.ReadAllText(file.FullName).Split('\n');

            Console.WriteLine();
            UIBasics.displayLine();
            Console.WriteLine();

            // Realitzem l'intent d'atac mitjançant un bucle paral·lel
            string match = null;
            Parallel.ForEach(passwords, pass =>
            {
                Console.WriteLine($"Provant contrasenya {pass}");

                // Aplica el delay
                Thread.Sleep(delay * 1000);

                if (password == pass.Trim())
                {
                    match = pass;
                    return;
                }
            });

            Console.WriteLine();
            UIBasics.displayLine();
            Console.WriteLine();

            if (match == null) Console.WriteLine("No s'han trobat coincidències");
            else Console.WriteLine($"S'ha trobat una coincidència: {match}");

            UIBasics.pressAnyKey();
        }
    }
}