using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    class Exercise
    {
        private byte course;
        private byte lesson;
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
        public int GetLesson()
        {
            return lesson;
        }
        public void SetLesson(int lesson)
        {
            this.lesson = (byte)lesson;
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
