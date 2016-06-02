using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class Element implements the elements of 
    /// the game like keyboard or menus
    /// </summary>
    class Element
    {
        private int[] originTime;
        private int[] currentTime;
        private int xKeyboard;
        private int yKeyboard;
        private int xHands;
        private int yHands;
        private int xMenu;
        private int yMenu;

        public Element()
        {
            // Approximate coordinates
            xKeyboard = 0;
            yKeyboard = 17;
            xHands = 105;
            yHands = 30;
            xMenu = 118;
            yMenu = 26;
            originTime = new int[3];
            currentTime = new int[3];
        }

        /// <summary>
        /// This function draws in console the keyboad build by chars
        /// Implement by Pablo Padilla
        /// </summary>
        public void Keyboard()
        {
            Console.SetCursorPosition(xKeyboard, yKeyboard);
            Console.WriteLine("     ______   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ____________");
            Console.WriteLine("    |      | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |            |");
            Console.WriteLine("    | ESC  | | 1 | | 2 | | 3 | | 4 | | 5 | | 6 | | 7 | | 8 | | 9 | | 0 | | = | | ¡ | |   DELETE   |");
            Console.WriteLine("    |______| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |____________|");
            Console.WriteLine("                   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   _______");
            Console.WriteLine("                  |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |       |");
            Console.WriteLine("                  | Q | | W | | E | | R | | T | | Y | | U | | I | | O | | P | | ` | | + | | ENTER |");
            Console.WriteLine("                  |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |       |");
            Console.WriteLine("     ___________   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___  |       |");
            Console.WriteLine("    |           | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |       |");
            Console.WriteLine("    |   MAYUS   | | A | | S | | D | | F | | G | | H | | J | | K | | L | | Ñ | | ´ | | Ç | |       |");
            Console.WriteLine("    |___________| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |_______|");
            Console.WriteLine("     _________   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   _______________");
            Console.WriteLine("    |         | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |               |");
            Console.WriteLine("    |  SHIFT  | | > | | Z | | X | | C | | V | | B | | N | | M | | , | | . | | - | |     SHIFT     |");
            Console.WriteLine("    |_______ _| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |_______________|");
            Console.WriteLine("     _________               ___   ___________________________                                    ");
            Console.WriteLine("    |         |             |   | |                           |                                   ");
            Console.WriteLine("    | CONTROL |             |ALT| |          SPACE            |                                   ");
            Console.WriteLine("    |_________|             |___| |___________________________|                                   ");

        }

        /// <summary>
        /// This function draws in console the chars to look like hands
        /// Build and reescalated by Pablo padilla
        /// </summary>
        private void Hands()
        {
            Console.SetCursorPosition(xHands, yHands);
            Console.WriteLine("     .-.               .-.     ");
            Console.SetCursorPosition(xHands, yHands + 1);
            Console.WriteLine("   .-| |-.           .-| |-.   ");
            Console.SetCursorPosition(xHands, yHands + 2);
            Console.WriteLine(" .-| | | |           | | | |-. ");
            Console.SetCursorPosition(xHands, yHands + 3);
            Console.WriteLine(" | | | | |-.       .-| | | | | ");
            Console.SetCursorPosition(xHands, yHands + 4);
            Console.WriteLine(" | '     | |       | |     ` | ");
            Console.SetCursorPosition(xHands, yHands + 5);
            Console.WriteLine("  \\       /         \\       / ");
            Console.SetCursorPosition(xHands, yHands + 6);
            Console.WriteLine("   |     |           |     |  ");
        }

        /// <summary>
        /// This function draws in the indicated position the menu
        /// </summary>
        public void Menu(int[] originTime, int[] currentTime)
        {
            // TODO

            Console.SetCursorPosition(xMenu, yMenu);
            Console.WriteLine("Time");
            this.originTime = originTime;
            this.currentTime = currentTime;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(xMenu - 2, yMenu + 1);
            Console.WriteLine((currentTime[0] - originTime[0]).ToString("00") + ":" +
                    (currentTime[1] - originTime[1]).ToString("00") +
                    ":" + (currentTime[2] - originTime[2]).ToString("00"));
        }


        public void Draw()
        {
            Console.Clear();
            Keyboard();
            Hands();
            Menu(originTime, currentTime);
        }
    }
}
