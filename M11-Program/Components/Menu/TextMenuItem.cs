using System;
using System.Collections.Generic;
using System.Text;

namespace M11_Program.Components.Menu
{
    /*
     * Classe del menú de text
     */
    class TextMenuItem: MenuItem
    {
        public TextMenuItem(string text, Screens.IScreen screen) : base(text, screen) {}
    }
}