using System.Collections.Generic;

namespace EpmTrnHW03_1
{
    class Teacher : Man
    {
        private List<Student> _students;
        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }

        public Teacher(string name, int age, Gender gender, double weight)
            : base(name, age, gender, weight)
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public void AddStudyYears(int value)
        {
            foreach (var item in _students)
            {
                item.AddStudyYear(value);
            }
        }
    }
}
