using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    internal class StudentManager
    {
        private static int studentsCount = 0;
        private static int subjectsCount = 0;
        public static Student[] Students { get; set; } = new Student[500];
        public static Subject[] Subjects { get; set; } = new Subject[5000];

        public static void AddStudent()
        {
            Students[studentsCount++] = new Student()
            {
                Id = studentsCount,
                FirstName = EnterStringValueFromConsole("Enter first name: "),
                MiddleName = EnterStringValueFromConsole("Enter Middle name: "),
                LastName = EnterStringValueFromConsole("Enter Last name: ")
            };
        }

        public static void AddSubject()
        {
            Subjects[subjectsCount++] = new Subject()
            {
                Id = subjectsCount,
                Name = EnterStringValueFromConsole("Enter subject name: ")
            };
        }

        public static void PrintAllStudents()
        {
            for (int i = 0; i < studentsCount; i++)
            {
                Students[i].Print();
            }
        }

        public static void PrintAllSubjects()
        {
            for (int i = 0; i < subjectsCount; i++)
            {
                Subjects[i].Print();
            }
        }

        public static void AddGrade()
        {
            Student student = FindStudentById();
            Subject subject = FindSubjectById();

            double grade = EnterDoubleValueFromConsole("Enter grade: ");

            student.AddStudentRecord(subject, grade);
        }

        public static void PrintAllStudentGrades()
        {
            Student student = FindStudentById();
            Subject subject = FindSubjectById();

            student.PrintAllGrades(subject);
        }

        private static string EnterStringValueFromConsole(string message, int strMinLength = 3)
        {
            string value = string.Empty;
            do
            {
                Console.Write(message);
                value = Console.ReadLine();
            } while (value.Length < strMinLength);

            return value;
        }

        private static int EnterIntValueFromConsole(string message)
        {
            int result = 0;
            bool success = false;
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();
                success = Int32.TryParse(value, out result);
            } while (!success);

            return result;
        }

        private static double EnterDoubleValueFromConsole(string message)
        {
            double result = 0;
            bool success = false;
            do
            {
                Console.Write(message);
                string value = Console.ReadLine();
                success = Double.TryParse(value, out result);
            } while (!success);

            return result;
        }

        private static Student FindStudentById()
        {
            Student student = null;
            do
            {
                PrintAllStudents();
                int studentId = EnterIntValueFromConsole("Enter student id: ");

                for (int i = 0; i < studentsCount; i++)
                {
                    if (Students[i].Id == studentId)
                    {
                        student = Students[i];
                    }
                }

            } while (student == null);

            return student;
        }

        private static Subject FindSubjectById()
        {
            Subject subject = null;
            do
            {
                PrintAllSubjects();
                int subjectId = EnterIntValueFromConsole("Enter subject id: ");
                for (int i = 0; i < subjectsCount; i++)
                {
                    if (Subjects[i].Id == subjectId)
                    {
                        subject = Subjects[i];
                    }
                }
            } while (subject == null);

            return subject;
        }
    }
}
