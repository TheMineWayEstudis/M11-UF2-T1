using System;
using System.Collections.Generic;
using System.Text;

namespace M11_Program.Components.Menu
{
    /*
     * Classe que permet mostrar menús i treballar amb ells
     */
    class Menu
    {
        private MenuItem[] _menuItems;
        private string _title;
        public Menu(MenuItem[] menuItems, string title)
        {
            _menuItems = menuItems;
            _title = title;
        }

        public void display()
        {
            int currentIndex = 0; // Emmagatzema l'índex actual
            do
            {
                Console.Clear();
                Console.WriteLine($"\n   {_title}\n");
                UIBasics.displayLine();
                Console.WriteLine();
                for (int i = 0; i < _menuItems.Length; i++)
                {
                    MenuItem item = _menuItems[i];
                    displayItem(item, currentIndex == i);
                    Console.WriteLine();
                }
                Console.WriteLine();

                UIBasics.displayLine();
                displayDescription();

                ConsoleKey key = Console.ReadKey().Key;

                // Surt del menú
                if (key == ConsoleKey.Escape) return;
                // Obre el menú de l'ítem
                else if (key == ConsoleKey.Enter) _menuItems[currentIndex].openScreen();
                else
                    currentIndex = processIndex(currentIndex, key == ConsoleKey.UpArrow ? -1 : key == ConsoleKey.DownArrow ? 1 : 0, _menuItems.Length - 1);
            } while (true);
        }

        private void displayItem(MenuItem item, bool isSelected)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.Write(" ");
            if (isSelected)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("$ ");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else Console.Write("  ");
            Console.Write(item.text);
            Console.ForegroundColor = color;
        }

        private int processIndex(int index, int incrementBy, int max)
        {
            index += incrementBy;

            if (index < 0) index = max;
            else if (index > max) index = 0;

            return index;
        }

        private void displayDescription()
        {
            Console.WriteLine("\n   Fes servir les fletxes del teclat per moure't per la interfície.\n   Prem \"Esc\" per tornar enrere o \"Enter\" per seleccionar un ítem.");
        }
    }
}