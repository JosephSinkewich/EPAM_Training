using System;

namespace EpmTrnHW03_1
{
    class Student : Man
    {
        private int _studyYear;
        public int StudyYear
        {
            get
            {
                return _studyYear;
            }
            set
            {
                if (value >= 0)
                {
                    _studyYear = value;
                }
                else
                {
                    throw new Exception("StudyYear most be not-negative value");
                }
            }
        }


        public Student(string name, int age, Gender gender, double weight, int studyYear) 
            : base(name, age, gender, weight)
        {
            StudyYear = studyYear;
        }

        public void AddStudyYear(int value)
        {
            StudyYear += value;
        }
    }
}
