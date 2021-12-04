using System;
using System.IO;

namespace M11_Program.Components
{
    class UIBasics
    {
        public static void displayLine()
        {
            for (int i = 0; i < Console.WindowWidth; i++) Console.Write("*");
        }

        public static string readText(string label, string defaultValue = null)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.Write($"{label}: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string val = Console.ReadLine();
            Console.ForegroundColor = color;
            return val == "" ? defaultValue : val;
        }

        public static int readNumber(string label, int defaultValue = 0)
        {
            try
            {
                return int.Parse(readText(label));
            } catch(System.Exception e)
            {
                return defaultValue;
            }
        }

        public static bool getYesNo(string label)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.Write($"{label} (Y/N): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool option = Console.ReadKey().Key == ConsoleKey.Y;
            Console.ForegroundColor = color;
            Console.WriteLine();
            return option;
        }

        public static FileInfo getFile()
        {
            string name = readText("Escriu el nom del fitxer (buit per sortir)");
            if (name == "") return null;

            if(!File.Exists(Directory.GetCurrentDirectory() + @"\" + name))
            {
                return null;
            }

            return new FileInfo(Directory.GetCurrentDirectory() + @"\" + name);
        }

        public static void pressAnyKey()
        {
            Console.WriteLine("Prem qualsevol tecla per continuar...");
            Console.ReadKey();
        }
    }
}