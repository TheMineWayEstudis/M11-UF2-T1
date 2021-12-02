using System;
using System.Collections.Generic;
using System.Text;

namespace M11_Program.Components
{
    class UIBasics
    {
        public static void displayLine()
        {
            for (int i = 0; i < Console.WindowWidth; i++) Console.Write("*");
        }
    }
}