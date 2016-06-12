using System;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class Element implements the elements of 
    /// the game like keyboard or menus
    /// </summary>
    class Element
    {
        private DateTime origin;
        private DateTime current;
        private int mistakes;
        private int BPM;
        protected const int XKEYBOARD = 0;
        protected const int YKEYBOARD = 17;
        protected const int XHANDS = 105;
        protected const int YHANDS = 30;
        private const int XBMP = 118;
        private const int YBMP = 19;
        private const int XMISTAKES = 116;
        private const int YMISTAKES = 23;
        private const int XCHRONOMETER = 118;
        private const int YCHRONOMETER = 27;
        protected int course;
        protected int level;
        protected const int COURSEHIDDENMARKKEYBOARD = 2;
        protected const int COURSEHIDDENHANDS = 1;
        protected const int LEVELHIDDENHANDS = 2;
        protected const int COURSEHIDDENKEYBOARD = 2;
        protected const int LEVELHIDDENKEYBOARD = 2;
        private int totalPulsations;
        private int seconds;
        private int minutes;
        private int hours;

        public Element()
        {
            // Approximate coordinates
            mistakes = 0;
        }

        public void SetTotalPulsations(int totalPulsations)
        {
            this.totalPulsations = totalPulsations;
        }

        public void SetOrigin(DateTime origin)
        {
            this.origin = origin;
        }

        public void SetCurrent(DateTime current)
        {
            this.current = current;
        }

        public void SetMistakes(int mistakes)
        {
            this.mistakes = mistakes;
        }

        public void SetLevel(int level)
        {
            this.level = level;
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
            Console.SetCursorPosition(XKEYBOARD, YKEYBOARD);
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
            Console.SetCursorPosition(XHANDS, YHANDS);
            Console.WriteLine("     .-.               .-.     ");
            Console.SetCursorPosition(XHANDS, YHANDS + 1);
            Console.WriteLine("   .-| |-.           .-| |-.   ");
            Console.SetCursorPosition(XHANDS, YHANDS + 2);
            Console.WriteLine(" .-| | | |           | | | |-. ");
            Console.SetCursorPosition(XHANDS, YHANDS + 3);
            Console.WriteLine(" | | | | |-.       .-| | | | | ");
            Console.SetCursorPosition(XHANDS, YHANDS + 4);
            Console.WriteLine(" | '     | |       | |     ` | ");
            Console.SetCursorPosition(XHANDS, YHANDS + 5);
            Console.WriteLine("  \\       /         \\       / ");
            Console.SetCursorPosition(XHANDS, YHANDS + 6);
            Console.WriteLine("   |     |           |     |  ");
        }

        private void BeatsPerMinute()
        {
            Console.SetCursorPosition(XBMP, YBMP);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BPM");
            Console.ForegroundColor = ConsoleColor.Gray;

            double totalMinutes = (minutes + (hours * 60) + (seconds / 60));
            if(totalMinutes > 0)
                BPM = Convert.ToInt32(totalPulsations / totalMinutes);

            Console.SetCursorPosition(XBMP + 1, YBMP + 1);
            Console.WriteLine(BPM);
            // TODO
        }

        private void Mistakes()
        {
            Console.SetCursorPosition(XMISTAKES, YMISTAKES);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mistakes");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(XMISTAKES + 3, YMISTAKES + 1);
            Console.WriteLine(mistakes.ToString("00"));
            // TODO
        }

        private void Chronometer()
        {
            Console.SetCursorPosition(XCHRONOMETER, YCHRONOMETER);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Time");
            Console.ForegroundColor = ConsoleColor.Gray;

            TimeSpan dif = current - origin;

            seconds = dif.Seconds;
            minutes = dif.Minutes;
            hours = dif.Hours;

            Console.SetCursorPosition(XCHRONOMETER - 2, YCHRONOMETER + 1);
            Console.WriteLine(hours.ToString("00") + ":" +
                        minutes.ToString("00") + ":" +
                        seconds.ToString("00"));
        }

        /// <summary>
        /// This function draws in the indicated position the menu
        /// </summary>
        public void Menu()
        {
            BeatsPerMinute();
            Mistakes();
            Chronometer();
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

            Menu();
        }
    }
}
