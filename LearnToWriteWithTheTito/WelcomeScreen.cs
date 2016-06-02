using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class WellcomeScreen implements the
    /// start's program screen 
    /// </summary>
    class WelcomeScreen
    {
        public void CheckKey()
        {
            //TO DO
        }
        public void Draw()
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("                                   _        ______        __       ____    __    _          _________     _____     ");
            Console.WriteLine("                                  | |      |  ____|      /  \\     |  _ \\  |  \\  | |        |___   ___|   /  _  \\    ");
            Console.WriteLine("                                  | |      | |__        / /\\ \\    | |_\\ \\ | . \\ | |            | |      /  / \\  \\   ");
            Console.WriteLine("                                  | |      |  __|      / /__\\ \\   |  ___/ | |\\ \\| |            | |     |  |   |  |  ");
            Console.WriteLine("                                  | |____  | |_____   / /____\\ \\  | |\\ \\  | | \\ ' |            | |      \\  \\_/  /   ");
            Console.WriteLine("                                  |______| |_______| /_/      \\_\\ |_| \\_\\ |_|  \\__|            |_|       \\_____/    ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   __                 __  ____    _   _________   ______          __                 __  _   _________   _     _   ");
            Console.WriteLine("                   \\ \\      ___      / / |  _ \\  | | |___   ___| |  ____|         \\ \\      ___      / / | | |___   ___| | |   | |  ");
            Console.WriteLine("                    \\ \\    / _ \\    / /  | |_\\ \\ | |     | |     | |__             \\ \\    / _ \\    / /  | |     | |     | |___| |  ");
            Console.WriteLine("                     \\ \\  / / \\ \\  / /   |  ___/ | |     | |     |  __|             \\ \\  / / \\ \\  / /   | |     | |     |  ___  |  ");
            Console.WriteLine("                      \\ \\/ /   \\ \\/ /    | |\\ \\  | |     | |     | |_____            \\ \\/ /   \\ \\/ /    | |     | |     | |   | |  ");
            Console.WriteLine("                       \\__/     \\__/     |_| \\_\\ |_|     |_|     |_______|            \\__/     \\__/     |_|     |_|     |_|   |_|  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               _________   _     _   ______           _________   _   _________     _____     _   _   _   ");
            Console.WriteLine("                              |___   ___| | |   | | |  ____|         |___   ___| | | |___   ___|   /  _  \\   | | | | | |  ");
            Console.WriteLine("                                  | |     | |___| | | |__                | |     | |     | |      /  / \\  \\  | | | | | |  ");
            Console.WriteLine("                                  | |     |  ___  | |  __|               | |     | |     | |     |  |   |  | | | | | | |  ");
            Console.WriteLine("                                  | |     | |   | | | |_____             | |     | |     | |      \\  \\_/  /  |_| |_| |_|  ");
            Console.WriteLine("                                  |_|     |_|   |_| |_______|            |_|     |_|     |_|       \\_____/    _   _   _   ");
            Console.WriteLine("                                                                                                             |_| |_| |_|  ");

            Console.SetCursorPosition(58, 30);
            Console.WriteLine("To begin you have to press \"ENTER\"");
            Console.SetCursorPosition(59, 31);
            Console.WriteLine("To exit you have to press \"ESC\"");
            Console.ReadLine();
        }
        


    }
}
