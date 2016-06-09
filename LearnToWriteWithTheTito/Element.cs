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
        private int mistakes;
        protected int xKeyboard;
        protected int yKeyboard;
        protected int xHands;
        protected int yHands;
        private int xBPM;
        private int yBPM;
        private int xMistakes;
        private int yMistakes;
        private int xChronometer;
        private int yChronometer;
        protected int course;
        protected int level;
        protected const int COURSEHIDDENMARKKEYBOARD = 2;
        protected const int COURSEHIDDENHANDS = 1;
        protected const int LEVELHIDDENHANDS = 2;
        protected const int COURSEHIDDENKEYBOARD = 2;
        protected const int LEVELHIDDENKEYBOARD = 2;

        public Element()
        {
            // Approximate coordinates
            xKeyboard = 0;
            yKeyboard = 17;
            xHands = 105;
            yHands = 30;
            xBPM = 118;
            yBPM = 19;
            xMistakes = 116;
            yMistakes = 23;
            xChronometer = 118;
            yChronometer = 27;
            originTime = new int[3];
            currentTime= new int[3];
            mistakes = 0;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }

        public int GetCourse()
        {
            return course;
        }

        public void SetCourse(int course)
        {
            this.course = course;
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
            Console.WriteLine("                  | Q | | W | | E | | R | | T | | Y | | U | | I | | O | | P | | ` | | + | |       |");
            Console.WriteLine("                  |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |       |");
            Console.WriteLine("     ___________   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___  | ENTER |");
            Console.WriteLine("    |           | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |       |");
            Console.WriteLine("    |   MAYUS   | | A | | S | | D | | F | | G | | H | | J | | K | | L | | Ñ | | ´ | | Ç | |       |");
            Console.WriteLine("    |___________| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |_______|");
            Console.WriteLine("     _________   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   ___   _______________");
            Console.WriteLine("    |         | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |   | |               |");
            Console.WriteLine("    |  SHIFT  | | > | | Z | | X | | C | | V | | B | | N | | M | | , | | . | | - | |     SHIFT     |");
            Console.WriteLine("    |_________| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |___| |_______________|");
            Console.WriteLine("     _________               ___   ___________________________                                    ");
            Console.WriteLine("    |         |             |   | |                           |                                   ");
            Console.WriteLine("    | CONTROL |             |ALT| |           SPACE           |                                   ");
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

        private void BeatsPerMinute()
        {
            Console.SetCursorPosition(xBPM, yBPM);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BPM");
            Console.ForegroundColor = ConsoleColor.Gray;
            // TODO
        }

        private void Mistakes(int mistakes)
        {
            Console.SetCursorPosition(xMistakes, yMistakes);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mistakes");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(xMistakes + 3, yMistakes + 1);
            Console.WriteLine(mistakes.ToString("00"));
            // TODO
        }

        private void Chronometer(int[] originTime, int[] currentTime)
        {
            Console.SetCursorPosition(xChronometer, yChronometer);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Time");
            this.originTime = originTime;
            this.currentTime = currentTime;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(xChronometer - 2, yChronometer + 1);
            Console.WriteLine((currentTime[0] - originTime[0]).ToString("00") + ":" +
                    (currentTime[1] - originTime[1]).ToString("00") +
                    ":" + (currentTime[2] - originTime[2]).ToString("00"));
        }

        /// <summary>
        /// This function draws in the indicated position the menu
        /// </summary>
        public void Menu(int[] originTime, int[] currentTime, int mistakes)
        {
            BeatsPerMinute();
            Mistakes(mistakes);
            Chronometer(originTime, currentTime);
        }


        public void Draw()
        {
            Console.Clear();
            if (course < COURSEHIDDENKEYBOARD)
                Keyboard();
            else if(course == COURSEHIDDENKEYBOARD)
                if(level < LEVELHIDDENKEYBOARD)
                    Keyboard();

            if (course < COURSEHIDDENHANDS)
                Hands();
            else if (course == COURSEHIDDENHANDS)
                if (level < LEVELHIDDENHANDS)
                    Hands();

            Menu(originTime, currentTime, mistakes);
        }
    }
}
