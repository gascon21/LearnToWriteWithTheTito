using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    class Mark : Element
    {
        public void KeyBoard(char character, bool clear)
        {
            int yFirstLine = yKeyboard + 3;
            int ySecondLine = yKeyboard + 7;
            int yThirdLine = yKeyboard + 11;
            int yFourthLine = yKeyboard + 15;
            int yFifthLine = yKeyboard + 19;
            
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

            int xIniFirstLine = xKeyboard + 15;
            int xIniSecondLine = xKeyboard + 20;
            int xIniThirdLine = xKeyboard + 20;
            int xIniFourthLine = xKeyboard + 24;
            int xIniFifthLine = xKeyboard + 48;

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
                        ClearHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case '2':
                case 'w':
                case 's':
                case 'x':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 4, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 4, yHands + 2, ' ');
                    }
                    break;

                case '3':
                case 'e':
                case 'd':
                case 'c':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 6, yHands + 1, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 6, yHands + 1, ' ');
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
                        ClearHandsMark(xHands + 8, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 8, yHands + 2, ' ');
                    }
                    break;

                case '0':
                case 'p':
                case 'ñ':
                case '-':
                case '+':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 28, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 28, yHands + 3, ' ');
                    }
                    break;

                case '9':
                case 'o':
                case 'l':
                case '.':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 26, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 26, yHands + 2, ' ');
                    }
                    break;

                case '8':
                case 'i':
                case 'k':
                case ',':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 24, yHands + 1, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 24, yHands + 1, ' ');
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
                        ClearHandsMark(xHands + 22, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 22, yHands + 2, ' ');
                    }
                    break;

                case '*':
                case '_':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 28, yHands + 3, ' ');
                        ClearHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 28, yHands + 3, ' ');
                        DrawHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case ':':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 26, yHands + 2, ' ');
                        ClearHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 26, yHands + 2, ' ');
                        DrawHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case ';':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 24, yHands + 2, ' ');
                        ClearHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 24, yHands + 2, ' ');
                        DrawHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case '/':
                case '&':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 22, yHands + 2, ' ');
                        ClearHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 22, yHands + 2, ' ');
                        DrawHandsMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case '$':
                case '%':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 8, yHands + 2, ' ');
                        ClearHandsMark(xHands + 28, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawHandsMark(xHands + 8, yHands + 2, ' ');
                        DrawHandsMark(xHands + 28, yHands + 3, ' ');
                    }
                    break;

                case ' ':
                    if (clear)
                    {
                        ClearHandsMark(xHands + 10, yHands + 4, ' ');
                        ClearHandsMark(xHands + 20, yHands + 4, ' ');
                    }
                    else
                    {                                  
                        DrawHandsMark(xHands + 10, yHands + 4, ' ');
                        DrawHandsMark(xHands + 20, yHands + 4, ' ');
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
