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

            Console.SetCursorPosition(XBMP, YBMP + 1);
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
﻿using System.Collections.Generic;

namespace LearnToWriteWithTheTito
{
    class Exercise
    {
        private byte course;
        private byte level;
        private byte exercise;
        private string comment;
        private string time;
        private string speed;
        private string text;

        public int GetCourse()
        {
            return course;
        }
        public void SetCourse(int course)
        {
            this.course = (byte)course;
        }
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = (byte)level;
        }
        public int GetExercise()
        {
            return exercise;
        }
        public void SetExercise(int exercise)
        {
            this.exercise = (byte)exercise;
        }
        public string GetComment()
        {
            return comment;
        }
        public void SetComment(string comment)
        {
            this.comment = comment;
        }
        public string GetTime()
        {
            return time;
        }
        public void SetTime(string time)
        {
            this.time = time;
        }
        public string GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(string speed)
        {
            this.speed = speed;
        }
        public List<string> GetText()
        {
            List<string> newText = new List<string>();
            newText.Add(text);
            return newText;
        }
        public void SetText(List<string> newText)
        {
            text = newText[0];
        }
    }
}
﻿using System;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class LearnToWriteWithTheTito implements the main 
    /// program.
    /// </summary>
    class LearnToWriteWithTheTito
    {
        private int level;
        private int course;
        private int exercise;
        private TextWriting textWriting;
        private Element elements;
        private WelcomeScreen welcomeScreen;
        bool drawWelcome = true;
        private bool finish = false;

        public LearnToWriteWithTheTito()
        {
            textWriting = new TextWriting();
            elements = new Element();
            welcomeScreen = new WelcomeScreen();
        }

        private void Run(LearnToWriteWithTheTito LearnToWrite)
        {
            do
            {
                if (drawWelcome)
                {
                    welcomeScreen.Draw();
                    course = welcomeScreen.GetCourse();
                    level = welcomeScreen.GetLevel();
                    exercise = welcomeScreen.GetExercise();
                    finish = (welcomeScreen.GetFinish());
                    drawWelcome = false;
                    textWriting.SetDrawWelcome(false);
                }
                else
                {
                    course = textWriting.GetCourse();
                    level = textWriting.GetLevel();
                    exercise = textWriting.GetExercise();
                }
                if (!finish)
                {
                    textWriting.SetCourse(course);
                    textWriting.SetLevel(level);
                    textWriting.SetExercise(exercise);

                    elements.SetCourse(course);
                    elements.SetLevel(level);

                    elements.Draw();
                    textWriting.Write();
                    textWriting.Check();
                    drawWelcome = textWriting.GetDrawWelcome();
                }
            } while (!finish);
        }

        static void Main(string[] args)
        {
            Console.WindowHeight = 39;
            Console.WindowWidth = 150;
            LearnToWriteWithTheTito LearnToWrite = new LearnToWriteWithTheTito();
            LearnToWrite.Run(LearnToWrite);
        }
    }
}
﻿using System;

namespace LearnToWriteWithTheTito
{
    class Mark : Element
    {
        public void KeyBoard(char character, bool clear)
        {
            int yFirstLine = YKEYBOARD + 3;
            int ySecondLine = YKEYBOARD + 7;
            int yThirdLine = YKEYBOARD + 11;
            int yFourthLine = YKEYBOARD + 15;
            int yFifthLine = YKEYBOARD + 19;
            
            const int XKEY2 = 6;
            const int XKEY3 = 12;
            const int XKEY4 = 18;
            const int XKEY5 = 24;
            const int XKEY6 = 30;
            const int XKEY7 = 36;
            const int XKEY8 = 42;
            const int XKEY9 = 48;
            const int XKEY10 = 54;
            const int XKEY11 = 60;
            const int XKEY12 = 66;
            const int XSHIFTRIGTH = 66;
            const int XSHIFTLEFT = 15;

            int xIniFirstLine = XKEYBOARD + 15;
            int xIniSecondLine = XKEYBOARD + 20;
            int xIniThirdLine = XKEYBOARD + 20;
            int xIniFourthLine = XKEYBOARD + 24;
            int xIniFifthLine = XKEYBOARD + 48;

            switch (character)
            {
                case '1':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine, yFirstLine, '_');
                    }
                    break;

                case '2':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY2, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY2, yFirstLine, '_');
                    }
                    break;

                case '3':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY3, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY3, yFirstLine, '_');
                    }
                    break;

                case '4':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                    }
                    break;

                case '5':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                    }
                    break;

                case '6':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                    }
                    break;

                case '7':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                    }
                    break;

                case '8':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY8, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY8, yFirstLine, '_');
                    }
                    break;

                case '9':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY9, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    break;

                case '0':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    break;

                case 'q':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine, ySecondLine, '_');
                    }
                    break;

                case 'w':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY2, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY2, ySecondLine, '_');
                    }
                    break;

                case 'e':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY3, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY3, ySecondLine, '_');
                    }
                    break;

                case 'r':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY4, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY4, ySecondLine, '_');
                    }
                    break;

                case 't':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY5, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY5, ySecondLine, '_');
                    }
                    break;

                case 'y':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY6, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY6, ySecondLine, '_');
                    }
                    break;

                case 'u':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY7, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY7, ySecondLine, '_');
                    }
                    break;

                case 'i':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY8, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY8, ySecondLine, '_');
                    }
                    break;

                case 'o':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY9, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY9, ySecondLine, '_');
                    }
                    break;

                case 'p':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY10, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY10, ySecondLine, '_');
                    }
                    break;

                case 'a':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine, yThirdLine, '_');
                    }
                    break;

                case 's':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY2, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY2, yThirdLine, '_');
                    }
                    break;

                case 'd':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY3, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY3, yThirdLine, '_');
                    }
                    break;

                case 'f':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY4, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY4, yThirdLine, '_');
                    }
                    break;

                case 'g':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY5, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY5, yThirdLine, '_');
                    }
                    break;

                case 'h':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY6, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY6, yThirdLine, '_');
                    }
                    break;

                case 'j':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY7, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY7, yThirdLine, '_');
                    }
                    break;

                case 'k':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY8, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY8, yThirdLine, '_');
                    }
                    break;

                case 'l':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY9, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY9, yThirdLine, '_');
                    }
                    break;

                case 'ñ':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniThirdLine + XKEY10, yThirdLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniThirdLine + XKEY10, yThirdLine, '_');
                    }
                    break;

                case 'z':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine, yFourthLine, '_');
                    }
                    break;

                case 'x':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY2, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY2, yFourthLine, '_');
                    }
                    break;

                case 'c':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY3, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY3, yFourthLine, '_');
                    }
                    break;

                case 'v':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY4, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY4, yFourthLine, '_');
                    }
                    break;

                case 'b':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY5, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY5, yFourthLine, '_');
                    }
                    break;

                case 'n':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY6, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY6, yFourthLine, '_');
                    }
                    break;

                case 'm':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY7, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY7, yFourthLine, '_');
                    }
                    break;

                case ',':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                    }
                    break;

                case '.':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                    }
                    break;

                case '-':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                    }
                    break;

                case '+':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY12, ySecondLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY12, ySecondLine, '_');
                    }
                    break;

                case '*':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniSecondLine + XKEY12, ySecondLine, '_');
                        ClearKeyboardMark(xIniSecondLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniSecondLine + XKEY12, ySecondLine, '_');
                        DrawKeyboardMark(xIniSecondLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case '/':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                        ClearKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                        DrawKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case '&':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                        ClearKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                        DrawKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case '$':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                        ClearKeyboardMark(xIniFourthLine + XSHIFTRIGTH, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                        DrawKeyboardMark(xIniFourthLine + XSHIFTRIGTH, yFourthLine, '_');
                    }
                    break;

                case '%':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                        ClearKeyboardMark(xIniFourthLine + XSHIFTRIGTH, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                        DrawKeyboardMark(xIniFourthLine + XSHIFTRIGTH, yFourthLine, '_');
                    }
                    break;

                case '_':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                        ClearKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                        DrawKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case ':':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                        ClearKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                        DrawKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case ';':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                        ClearKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                        DrawKeyboardMark(xIniFourthLine - XSHIFTLEFT, yFourthLine, '_');
                    }
                    break;

                case ' ':
                    if (clear)
                    {
                        ClearKeyboardMark(xIniFifthLine, yFifthLine, '_');
                    }
                    else
                    {
                        DrawKeyboardMark(xIniFifthLine, yFifthLine, '_');
                    }
                    break;
            }
        }

        public void Hand(char character, bool clear)
        {
            switch (character)
            {
                case '1':
                case 'q':
                case 'a':
                case 'z':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    break;

                case '2':
                case 'w':
                case 's':
                case 'x':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 4, YHANDS + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 4, YHANDS + 2, ' ');
                    }
                    break;

                case '3':
                case 'e':
                case 'd':
                case 'c':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 6, YHANDS + 1, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 6, YHANDS + 1, ' ');
                    }
                    break;

                case '4':
                case '5':
                case 'r':
                case 't':
                case 'f':
                case 'g':
                case 'v':
                case 'b':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 8, YHANDS + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 8, YHANDS + 2, ' ');
                    }
                    break;

                case '0':
                case 'p':
                case 'ñ':
                case '-':
                case '+':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                    }
                    break;

                case '9':
                case 'o':
                case 'l':
                case '.':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 26, YHANDS + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 26, YHANDS + 2, ' ');
                    }
                    break;

                case '8':
                case 'i':
                case 'k':
                case ',':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 24, YHANDS + 1, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 24, YHANDS + 1, ' ');
                    }
                    break;

                case '7':
                case '6':
                case 'u':
                case 'y':
                case 'j':
                case 'h':
                case 'm':
                case 'n':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 22, YHANDS + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 22, YHANDS + 2, ' ');
                    }
                    break;

                case '*':
                case '_':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                        ClearHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                        DrawHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    break;

                case ':':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 26, YHANDS + 2, ' ');
                        ClearHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 26, YHANDS + 2, ' ');
                        DrawHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    break;

                case ';':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 24, YHANDS + 2, ' ');
                        ClearHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 24, YHANDS + 2, ' ');
                        DrawHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    break;

                case '/':
                case '&':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 22, YHANDS + 2, ' ');
                        ClearHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 22, YHANDS + 2, ' ');
                        DrawHandsMark(XHANDS + 2, YHANDS + 3, ' ');
                    }
                    break;

                case '$':
                case '%':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 8, YHANDS + 2, ' ');
                        ClearHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(XHANDS + 8, YHANDS + 2, ' ');
                        DrawHandsMark(XHANDS + 28, YHANDS + 3, ' ');
                    }
                    break;

                case ' ':
                    if (clear)
                    {
                        ClearHandsMark(XHANDS + 10, YHANDS + 4, ' ');
                        ClearHandsMark(XHANDS + 20, YHANDS + 4, ' ');
                    }
                    else
                    {                                  
                        DrawHandsMark(XHANDS + 10, YHANDS + 4, ' ');
                        DrawHandsMark(XHANDS + 20, YHANDS + 4, ' ');
                    }
                    break;
            }
        }

        public void DrawHandsMark(int xMark, int yMark, char symbol)
        {
            if (course < COURSEHIDDENHANDS)
            {
                Console.SetCursorPosition(xMark, yMark);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(symbol);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (course == COURSEHIDDENHANDS)
                if (level < LEVELHIDDENHANDS)
                {
                    Console.SetCursorPosition(xMark, yMark);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write(symbol);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
        }
        public void ClearHandsMark(int xMark, int yMark, char symbol)
        {
            if (course < COURSEHIDDENHANDS)
            {
                Console.SetCursorPosition(xMark, yMark);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(symbol);
            }
            else if (course == COURSEHIDDENHANDS)
                if (level < LEVELHIDDENHANDS)
                {
                    Console.SetCursorPosition(xMark, yMark);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(symbol);
                }
        }

        public void DrawKeyboardMark(int xMark, int yMark, char symbol)
        {
            if (course < COURSEHIDDENMARKKEYBOARD)
            {
                Console.SetCursorPosition(xMark, yMark);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(symbol);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void ClearKeyboardMark(int xMark, int yMark, char symbol)
        {
            if (course < COURSEHIDDENMARKKEYBOARD)
            {
                Console.SetCursorPosition(xMark, yMark);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(symbol);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class Record: Contains the implemantation
    /// of all the records playables on the game.
    /// </summary>
    class Records
    {
        //TO DO
    }
}
﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace LearnToWriteWithTheTito
{
    class TextWriting
    {
        private bool finishCheck;
        private DateTime origin;
        private Mark marks;
        private Element element;
        private Exercise exercises;
        private bool drawWelcome;
        private int course;
        private int level;
        private int exercise;
        const int WIDTHSCREAN = 135;

        public TextWriting()
        {
            element = new Element();
            marks = new Mark();
            exercises = new Exercise();
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

        public int GetExercise()
        {
            return exercise;
        }

        public void SetExercise(int exercise)
        {
            this.exercise = exercise;
        }

        public bool GetDrawWelcome()
        {
            return drawWelcome;
        }

        public void SetDrawWelcome(bool drawWelcome)
        {
            this.drawWelcome = drawWelcome;
        }

        /// <summary>
        /// Read  the only phrase that is in the file at the appropriate level,
        /// which has passed through a parameter
        /// </summary>
        /// <param name="level">Parameter indicating the level to be read</param>
        public void Read()
        {
            string fileName = course.ToString("00") + level.ToString("00")
                    + exercise.ToString("00") + ".meca";
            if (File.Exists(fileName))
            {
                try
                {
                    StreamReader input = File.OpenText(fileName);
                    List<string> text = new List<string>();
                    string line;

                    line = input.ReadLine();
                    exercises.SetCourse(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetLevel(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetExercise(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetComment(line);

                    line = input.ReadLine();
                    exercises.SetTime(line);

                    line = input.ReadLine();
                    exercises.SetSpeed(line);

                    /*do
                    {
                        line = input.ReadLine();
                        if (line != null)
                        {
                            text.Add(line);
                        }
                    } while (line != null);*/

                    line = input.ReadLine();
                    text.Add(line);
                    exercises.SetText(text);
                    input.Close();
                }
                catch (PathTooLongException)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("Path too long");
                }
                catch (IOException)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("Could not read the file");
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("An error has occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }

        /// <summary>
        /// This function places the cursor coordinates x and y and write the 
        /// corresponding phrase at the level
        /// </summary>
        /// <param name="level">Parameter indicating the level to be write</param>
        public void Write()
        {
            int xText = 5;
            int yText = 1;
            Read();
            Console.SetCursorPosition(xText, yText);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Course: " + exercises.GetCourse() +
                    " Level: " + exercises.GetLevel() + " Exercise: " +
                    exercises.GetExercise() + " " + exercises.GetComment());
            Console.ForegroundColor = ConsoleColor.Gray;
            yText ++;
            Console.SetCursorPosition(xText, yText);

            for (int i = 0; i < exercises.GetText()[0].Length; i ++)
            {
                if((i % WIDTHSCREAN == 0) && (i > 0))
                {
                    yText ++;
                    Console.SetCursorPosition(xText, yText);
                }
                Console.Write(exercises.GetText()[0][i]);
            }
        }

        /// <summary>
        /// This function places the cursor coordinates x and y and is 
        /// writing it typed by the user while checking failures
        /// </summary>
        /// <param name="level">Parameter indicating the level to be check</param>
        public void Check()
        {
            marks.SetCourse(course);
            marks.SetLevel(level);
            bool lastCourseLevelExercice = false;
            const int LASTCOURSE = 2;
            const int LASTLEVEL = 3;
            const int LASTEXERCISE = 10;
            origin = DateTime.Now;
            element.SetOrigin(origin);
            int xWrite = 5;
            int yWrite = 9;
            finishCheck = false;
            bool enterKey = false;
            int yArrow = 0;
            int xOutMessage = 65;
            int yOutMessage = 35;
            int mistakes = 0;
            int currentPos = 0;
            int totalPulsations = 0;
            //int currentWord = 0;
            //int currentPosInWord = 0;
            //string[] words = exercises[0].GetText()[0].Split(' ');
            int posX = 0;
            //bool finish;

            Console.SetCursorPosition(xWrite, yWrite);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Writed text(Green correct, red mistake)");
            Console.SetCursorPosition(xOutMessage, yOutMessage);
            Console.WriteLine("Pres esc to return to the welcome screen");
            Console.ForegroundColor = ConsoleColor.Gray;

            yWrite += 1;
            while (!finishCheck)
            {
                //finish = false;
                DateTime current = DateTime.Now;

                element.SetMistakes(mistakes);
                element.SetTotalPulsations(totalPulsations);
                element.SetCurrent(current);

                element.Menu();

                marks.Hand(exercises.GetText()[0][currentPos], false);
                marks.KeyBoard(exercises.GetText()[0][currentPos], false);

                Thread.Sleep(20);
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(xWrite + posX, yWrite);
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Escape)
                    {
                        totalPulsations++;
                        if (key.KeyChar != exercises.GetText()[0][currentPos])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(key.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            mistakes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(key.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        marks.Hand(exercises.GetText()[0][currentPos], true);
                        marks.KeyBoard(exercises.GetText()[0][currentPos], true);

                        posX++;
                        currentPos++;

                        // Reflects the value of the key, check it and if it is
                        // right printed with green, if the letter is incorrect
                        // printed in red
                        if ((currentPos % WIDTHSCREAN == 0) && (currentPos > 0))
                        {
                            yWrite += 1;
                            posX = 0;
                            Console.SetCursorPosition(xWrite, yWrite);
                        }

                        // Check if you typed is correct or not, if it is passed 
                        // to the next level, if not asking you to try again
                        // lack of level rise
                        if (currentPos == exercises.GetText()[0].Length)
                        {
                            finishCheck = true;
                            
                            if (mistakes != 0)
                            {
                                Console.SetCursorPosition(xWrite, yWrite + 4);
                                Console.WriteLine("Wrong answer");
                                Console.SetCursorPosition(xWrite, yWrite + 5);
                                Console.WriteLine("Back to welcome screan");
                                Console.SetCursorPosition(xWrite, yWrite + 6);
                                Console.WriteLine("Repeat the exercise");

                                do
                                {
                                    Console.SetCursorPosition(xWrite - 3, yWrite
                                            + 5 + yArrow);
                                    Console.Write("->");
                                    Thread.Sleep(15);

                                    if (Console.KeyAvailable)
                                    {
                                        key = Console.ReadKey(true);
                                        if (key.Key == ConsoleKey.UpArrow)
                                        {
                                            Console.SetCursorPosition(xWrite - 3,
                                                        yWrite + 5 + yArrow);
                                            Console.Write("  ");
                                            if (yArrow > 0)
                                            {
                                                yArrow--;
                                            }
                                        }
                                        if (key.Key == ConsoleKey.DownArrow)
                                        {
                                            Console.SetCursorPosition(xWrite - 3,
                                                        yWrite + 5 + yArrow);
                                            Console.Write("  ");
                                            if (yArrow < 1)
                                            {
                                                yArrow++;
                                            }
                                        }
                                    }
                                    else if (key.Key == ConsoleKey.Enter)
                                    {
                                        enterKey = true;
                                        if(yArrow == 0)
                                            drawWelcome = true;
                                    }
                                } while (!enterKey);

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.SetCursorPosition(xWrite, yWrite + 3);
                                Console.WriteLine("Correct!");
                                Console.SetCursorPosition(xWrite, yWrite + 4);
                                Console.WriteLine("Back to welcome screan");

                                if (LASTCOURSE == course && LASTLEVEL == level &&
                                        LASTEXERCISE == exercise)
                                    lastCourseLevelExercice = true;

                                if (!lastCourseLevelExercice)
                                {
                                    Console.SetCursorPosition(xWrite, yWrite + 5);
                                    Console.WriteLine("Go to the next level");
                                    Console.WriteLine();

                                    do
                                    {
                                        Console.SetCursorPosition(xWrite - 3, yWrite
                                                + 4 + yArrow);
                                        Console.Write("->");
                                        Thread.Sleep(15);

                                        if (Console.KeyAvailable)
                                        {
                                            key = Console.ReadKey(true);
                                            if (key.Key == ConsoleKey.UpArrow)
                                            {
                                                Console.SetCursorPosition(xWrite - 3,
                                                            yWrite + 4 + yArrow);
                                                Console.Write("  ");
                                                if (yArrow > 0)
                                                {
                                                    yArrow--;//todo
                                                }
                                            }
                                            else if (key.Key == ConsoleKey.DownArrow)
                                            {
                                                Console.SetCursorPosition(xWrite - 3,
                                                            yWrite + 4 + yArrow);
                                                Console.Write("  ");
                                                if (yArrow < 1)
                                                {
                                                    yArrow++;//todo
                                                }
                                            }
                                            else if (key.Key == ConsoleKey.Enter)
                                            {
                                                enterKey = true;
                                                if (yArrow == 0)
                                                    drawWelcome = true;
                                                else
                                                {
                                                    exercise++;

                                                    if (exercise > LASTEXERCISE)
                                                    {
                                                        exercise = 1;
                                                        level++;

                                                        if (level > LASTLEVEL)
                                                        {
                                                            level = 1;
                                                            course++;
                                                            if (course > LASTCOURSE)
                                                            {
                                                                course = LASTCOURSE;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } while (!enterKey);
                                }
                                else
                                {
                                    Console.SetCursorPosition(xWrite - 3, yWrite
                                                + 4 + yArrow);
                                    Console.Write("->");
                                    do
                                    {
                                        if (Console.KeyAvailable)
                                        {
                                        
                                            key = Console.ReadKey(true);
                                            if (key.Key == ConsoleKey.Enter)
                                            {
                                                enterKey = true;
                                                drawWelcome = true;
                                            }
                                        
                                        }
                                    } while (!enterKey);
                                }
                            }
                        }
                    }
                    else
                    {
                        finishCheck = true;
                        drawWelcome = true;
                    }
                }
            }
        }
    }
}
﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class WellcomeScreen implements the
    /// start's program screen 
    /// </summary>
    class WelcomeScreen
    {
        private int course;
        private int level;
        private int exercise;
        bool finish = false;
        List<string> exercises = new List<string>();

        public int GetLevel()
        {
            return level;
        }

        public int GetCourse()
        {
            return course;
        }

        public int GetExercise()
        {
            return exercise;
        }

        public bool GetFinish()
        {
            return finish;
        }

        public void ListOfExercises()
        {
            if (exercises.Count == 0)
            {
                DirectoryInfo dir = new DirectoryInfo(".");
                FileInfo[] file = dir.GetFiles();
                for (int i = 0; i < file.Length; i++)
                {
                    if (file[i].FullName.Substring(file[i].FullName.Length - 5)
                        == ".meca")
                    {
                        exercises.Add(file[i].FullName.Substring(
                                file[i].FullName.Length - 11, 6));
                    }
                }
            }
        }

        public void ShowExercises(int startExercice)
        {
            int lastExercise = startExercice + 10;
            int yExercises;

            for (int i = startExercice; i < lastExercise; i++)
            {
                yExercises = i - startExercice;
                Console.SetCursorPosition(90, 27 + yExercises);
                Console.WriteLine("Course: " + exercises[i].Substring(0, 2)
                    + " Level: " + exercises[i].Substring(2, 2)
                    + " Exercise: " + exercises[i].Substring(4));
            }
        }

        public void CheckKey()
        {
            const int LASTCOURSE = 2;
            const int LASTLEVEL = 3;
            const int LASTEXERCISE = 10;
            int startExercice = 0;
            int pos = 0;
            course = 1;
            level = 1;
            exercise = 1;
            int yArrow = 0;
            ConsoleKeyInfo key;
            bool enterKeyOrEsc = false;
            ShowExercises(startExercice);
            do
            {
                Console.SetCursorPosition(87, 27 + yArrow);
                Console.Write("->");
                Thread.Sleep(15);
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                        if (pos >= 0)
                        {
                            Console.SetCursorPosition(87, 27 + yArrow);
                            Console.Write("  ");
                            
                            if(yArrow > 0)
                            {
                                yArrow--;
                                exercise--;
                                if (exercise < 1 )
                                {
                                    exercise = LASTEXERCISE;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = LASTLEVEL;
                                        course--;
                                        if (course < 1)
                                        {
                                            course = 1;
                                        }
                                    }
                                }
                            }
                            else if (pos <= startExercice)
                            {
                                yArrow = 0;
                                startExercice--;
                                ShowExercises(startExercice);

                                exercise--;
                                if (exercise < 1)
                                {
                                    exercise = LASTEXERCISE;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = LASTLEVEL;
                                        course--;
                                        if (course < 1)
                                        {
                                            course = 1;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            pos++;
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                        if (pos < exercises.Count)
                        {
                            Console.SetCursorPosition(87, 27 + yArrow);
                            Console.Write("  ");
                            
                            if (yArrow < 9)
                            {
                                yArrow++;
                                exercise++;

                                if (exercise > LASTEXERCISE) 
                                {
                                    exercise = 1;
                                    level++;

                                    if (level > LASTLEVEL) 
                                    {
                                        level = 1;
                                        course++;
                                        if (course > LASTCOURSE)
                                        {
                                            course = LASTCOURSE;
                                        }
                                    }
                                }
                            }
                            else if (pos >= startExercice + 10)
                            {
                                startExercice++;
                                ShowExercises(startExercice);

                                exercise++;

                                if (exercise > LASTEXERCISE) 
                                {
                                    exercise = 1;
                                    level++;

                                    if (level > LASTLEVEL) 
                                    {
                                        level = 1;
                                        course++;
                                        if (course > LASTCOURSE)
                                        {
                                            course = LASTCOURSE;
                                        }
                                    }
                                }
                            }
                            
                        }
                        else
                        {
                            pos--;
                        } 
                        
                    }
                    else if(key.Key == ConsoleKey.Enter)
                    {
                        enterKeyOrEsc = true;
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        finish = true;
                        enterKeyOrEsc = true;
                    }
                }
            } while (!enterKeyOrEsc && !finish);
        }

        public void Draw()
        {
            const int XOUTMESSAGE = 30;
            const int YOUTMESSAGE = 31;

            Console.Clear();
            Console.SetCursorPosition(0, 2);
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(XOUTMESSAGE, YOUTMESSAGE);
            Console.WriteLine("Pres ESC to exit");
            Console.SetCursorPosition(XOUTMESSAGE, YOUTMESSAGE + 1);
            Console.WriteLine("Use the arrow keys to move through the exercises");
            Console.SetCursorPosition(XOUTMESSAGE, YOUTMESSAGE + 2);
            Console.WriteLine("Press Enter to start with the selected exercise");
            Console.ForegroundColor = ConsoleColor.Gray;


            /*
            Console.SetCursorPosition(58, 30);
            Console.WriteLine("To begin you have to press \"ENTER\"");
            Console.SetCursorPosition(59, 31);
            Console.WriteLine("To exit you have to press \"ESC\"");
            */
            ListOfExercises();
            CheckKey();
        }
    }
}
