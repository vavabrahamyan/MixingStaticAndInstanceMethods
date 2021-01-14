using System;

namespace MixingStaticAndInstanceMethods
{
    public class Student
    {
        public string _firstName;
        public string _lastName;

        public void InitStudent(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public static void OutputBanner()
        {
            Console.WriteLine("Aren't we clever:");
        }

        public void OutputBannerAndName()
        {
            OutputBanner();

            OutputName(this);
        }

        public static void OutputName(Student student)
        {
            Console.WriteLine("Student's name is {0}",
                              student.ToNameString());
        }

        public string ToNameString()
        {
            return _firstName + " " + _lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.InitStudent("Madeleine", "Cather");

            Student.OutputBanner();
            Student.OutputName(student);
            Console.WriteLine();

            student.OutputBannerAndName();

            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
