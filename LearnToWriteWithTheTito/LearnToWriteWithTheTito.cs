using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class LearnToWriteWithTheTito implements the main 
    /// program.
    /// </summary>
    class LearnToWriteWithTheTito
    {
        private int level;
        private TextWriting textWriting;
        private Element elements;
        private WelcomeScreen welcomeScreen;

        public LearnToWriteWithTheTito()
        {
            level = 1;
            textWriting = new TextWriting();
            elements = new Element();
            welcomeScreen = new WelcomeScreen();
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }

        private void Run()
        {
            welcomeScreen.Draw();
            elements.Draw();
            textWriting.Write(level);
            textWriting.Check(level);
            

        }

        static void Main(string[] args)
        {
            Console.WindowHeight = 39;
            Console.WindowWidth = 150;
            LearnToWriteWithTheTito LearnToWrite = new LearnToWriteWithTheTito();
            LearnToWrite.Run();
        }
    }
}
