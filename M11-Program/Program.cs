using System;
using System.Collections.Generic;
using System.Text;
using M11_Program.Components.Menu;
using M11_Program.Components.Screens;

namespace M11_Program
{
    /*
     * PROGRAMA CREAT PER L'ASSIGNATURA D'M11
     * Com estic una mica boig i m'agrada programar coses he fet una sol·lució una mica més àmplia
     * 
     * Repositori públic: https://github.com/TheMineWayEstudis/M11-UF2-T1
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joel Campos - M11";
            Menu menu = new Menu(new Components.Menu.MenuItem[] {
                new TextMenuItem("Exercici 7: atac de diccionari", new Exer7()),
                new TextMenuItem("Exercici 8: cuc", new Exer8()),
                new TextMenuItem("Exercici 9: DOS", new Exer9())
            }, "Selecciona el programa");
            menu.display();
        }
    }
}