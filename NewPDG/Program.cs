using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewPDG
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Game Starting... 3. 2. 1.\n";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            //Console.WriteLine("Game Starting...");
            var play = new Game();
            play.Run();
            Console.WriteLine("Press any key to quit ...");
            Console.ReadKey();
        }
    }
}
