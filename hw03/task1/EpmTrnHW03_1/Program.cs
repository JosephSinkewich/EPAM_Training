namespace EpmTrnHW03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Joe", 20, Gender.Male, 75, 3);
            Student student2 = new Student("John", 20, Gender.Male, 55, 3);

            Teacher teacher = new Teacher("Arkady", 55, Gender.Male, 85);

            teacher.AddStudent(student1);
            teacher.AddStudent(student2);

            teacher.AddStudyYears(1);
        }
    }
}
