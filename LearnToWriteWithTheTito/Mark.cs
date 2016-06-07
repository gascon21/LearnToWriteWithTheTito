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
                        ClearMark(xIniFirstLine, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine, yFirstLine, '_');
                    }
                    break;

                case '2':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY2, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY2, yFirstLine, '_');
                    }
                    break;

                case '3':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY3, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY3, yFirstLine, '_');
                    }
                    break;

                case '4':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY4, yFirstLine, '_');
                    }
                    break;

                case '5':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY5, yFirstLine, '_');
                    }
                    break;

                case '6':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY6, yFirstLine, '_');
                    }
                    break;

                case '7':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY7, yFirstLine, '_');
                    }
                    break;

                case '8':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY8, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY8, yFirstLine, '_');
                    }
                    break;

                case '9':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY9, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    break;

                case '0':
                    if (clear)
                    {
                        ClearMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFirstLine + XKEY10, yFirstLine, '_');
                    }
                    break;

                case 'q':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine, ySecondLine, '_');
                    }
                    break;

                case 'w':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY2, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY2, ySecondLine, '_');
                    }
                    break;

                case 'e':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY3, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY3, ySecondLine, '_');
                    }
                    break;

                case 'r':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY4, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY4, ySecondLine, '_');
                    }
                    break;

                case 't':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY5, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY5, ySecondLine, '_');
                    }
                    break;

                case 'y':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY6, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY6, ySecondLine, '_');
                    }
                    break;

                case 'u':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY7, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY7, ySecondLine, '_');
                    }
                    break;

                case 'i':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY8, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY8, ySecondLine, '_');
                    }
                    break;

                case 'o':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY9, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY9, ySecondLine, '_');
                    }
                    break;

                case 'p':
                    if (clear)
                    {
                        ClearMark(xIniSecondLine + XKEY10, ySecondLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniSecondLine + XKEY10, ySecondLine, '_');
                    }
                    break;

                case 'a':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine, yThirdLine, '_');
                    }
                    break;

                case 's':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY2, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY2, yThirdLine, '_');
                    }
                    break;

                case 'd':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY3, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY3, yThirdLine, '_');
                    }
                    break;

                case 'f':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY4, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY4, yThirdLine, '_');
                    }
                    break;

                case 'g':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY5, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY5, yThirdLine, '_');
                    }
                    break;

                case 'h':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY6, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY6, yThirdLine, '_');
                    }
                    break;

                case 'j':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY7, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY7, yThirdLine, '_');
                    }
                    break;

                case 'k':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY8, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY8, yThirdLine, '_');
                    }
                    break;

                case 'l':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY9, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY9, yThirdLine, '_');
                    }
                    break;

                case 'ñ':
                    if (clear)
                    {
                        ClearMark(xIniThirdLine + XKEY10, yThirdLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniThirdLine + XKEY10, yThirdLine, '_');
                    }
                    break;

                case 'z':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine, yFourthLine, '_');
                    }
                    break;

                case 'x':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY2, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY2, yFourthLine, '_');
                    }
                    break;

                case 'c':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY3, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY3, yFourthLine, '_');
                    }
                    break;

                case 'v':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY4, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY4, yFourthLine, '_');
                    }
                    break;

                case 'b':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY5, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY5, yFourthLine, '_');
                    }
                    break;

                case 'n':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY6, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY6, yFourthLine, '_');
                    }
                    break;

                case 'm':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY7, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY7, yFourthLine, '_');
                    }
                    break;

                case ',':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY8, yFourthLine, '_');
                    }
                    break;

                case '.':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY9, yFourthLine, '_');
                    }
                    break;

                case '-':
                    if (clear)
                    {
                        ClearMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFourthLine + XKEY10, yFourthLine, '_');
                    }
                    break;

                case ' ':
                    if (clear)
                    {
                        ClearMark(xIniFifthLine, yFifthLine, '_');
                    }
                    else
                    {
                        DrawMark(xIniFifthLine, yFifthLine, '_');
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
                        ClearMark(xHands + 2, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 2, yHands + 3, ' ');
                    }
                    break;

                case '2':
                case 'w':
                case 's':
                case 'x':
                    if (clear)
                    {
                        ClearMark(xHands + 4, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 4, yHands + 2, ' ');
                    }
                    break;

                case '3':
                case 'e':
                case 'd':
                case 'c':
                    if (clear)
                    {
                        ClearMark(xHands + 6, yHands + 1, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 6, yHands + 1, ' ');
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
                        ClearMark(xHands + 8, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 8, yHands + 2, ' ');
                    }
                    break;

                case '0':
                case 'p':
                case 'ñ':
                case '-':
                    if (clear)
                    {
                        ClearMark(xHands + 28, yHands + 3, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 28, yHands + 3, ' ');
                    }
                    break;

                case '9':
                case 'o':
                case 'l':
                case '.':
                    if (clear)
                    {
                        ClearMark(xHands + 26, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 26, yHands + 2, ' ');
                    }
                    break;

                case '8':
                case 'i':
                case 'k':
                case ',':
                    if (clear)
                    {
                        ClearMark(xHands + 24, yHands + 1, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 24, yHands + 1, ' ');
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
                        ClearMark(xHands + 22, yHands + 2, ' ');
                    }
                    else
                    {
                        DrawMark(xHands + 22, yHands + 2, ' ');
                    }
                    break;

                case ' ':
                    if (clear)
                    {
                        ClearMark(xHands + 10, yHands + 4, ' ');
                        ClearMark(xHands + 20, yHands + 4, ' ');
                    }
                    else
                    {                                  
                        DrawMark(xHands + 10, yHands + 4, ' ');
                        DrawMark(xHands + 20, yHands + 4, ' ');
                    }
                    break;
            }
        }
        public void DrawMark(int xMark, int yMark, char symbol)
        {
            Console.SetCursorPosition(xMark, yMark);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(symbol);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void ClearMark(int xMark, int yMark, char symbol)
        {
            Console.SetCursorPosition(xMark, yMark);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(symbol);
        }
    }
}
