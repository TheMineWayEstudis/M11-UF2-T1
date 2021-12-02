using System;
using System.Collections.Generic;
using System.Text;

namespace M11_Program.Components.Menu
{
    /*
     * Classe encarregada de representar els ítems dels menús
     */
    abstract class MenuItem
    {
        private string _text;
        private Screens.IScreen _screen;

        public MenuItem(string text, Screens.IScreen screen)
        {
            _text = text;
            _screen = screen;
        }

        /*
         * Mostra l'element
         */
        virtual public string text { get { return _text; } }

        /*
         * Mostra el contingut per pantalla
         */
        virtual public void display() => Console.WriteLine(text);

        /*
         * Obre la pantalla de l'element
         */
        public void openScreen() => _screen.open();
    }
}