using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.NetworkInformation;

namespace M11_Program.Components.Screens
{
    class Exer9: IScreen
    {
        public void open() {
            Console.Clear();
            FileInfo file = UIBasics.getFile();
            if (file == null) return;

            string[] ips = File.ReadAllLines(file.FullName);

            foreach (string ip in ips) ping(ip, new Ping());
            
            UIBasics.pressAnyKey();
        }

        // Fa ping a una direcció
        public void ping(string dest, Ping sender)
        {
            ConsoleColor color = Console.ForegroundColor;
            try
            {
                PingReply reply = sender.Send(dest);

                // Imprimim l'estat del ping
                if (reply.Status == IPStatus.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"S'ha fet ping a \"{dest}\" en {reply.RoundtripTime}ms");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No s'ha pogut fer ping a \"{dest}\". Estat: {reply.Status.ToString()}");
                }
            } catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No s'ha pogut fer ping a \"{dest}\". Error: {e.Message}");
            }

            Console.ForegroundColor = color;
        }
    }
}