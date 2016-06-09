using System;

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
