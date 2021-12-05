﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace M11_Program.Components.Screens
{
    class Exer8: IScreen
    {
        public void open() {
            Console.Clear();
            Console.WriteLine("Indica el fitxer que vols replicar.");
            FileInfo file = UIBasics.getFile();
            if (file == null) return;

            for(int i = 0; i < 10; i++)
            {
                File.Copy(file.FullName, Directory.GetCurrentDirectory() + $@"\{$"Còpia {i + 1} " + file.Name}");
            }

            Console.WriteLine("\nS'ha replicat el fitxer");
            UIBasics.pressAnyKey();
        }
    }
}