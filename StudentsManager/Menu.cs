using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            int menu = 0;
            do
            {
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Add new subject");
                Console.WriteLine("3. Print all students");
                Console.WriteLine("4. Print all subjects");
                Console.WriteLine("5. Add student grade");
                Console.WriteLine("6. Print student grades");
                Console.WriteLine("0. Exit");
                Console.Write("Please select a menu: ");

                if (!Int32.TryParse(Console.ReadLine(), out menu))
                {
                    break;
                }

                Console.WriteLine();
                switch (menu)
                {
                    case 1:
                        StudentManager.AddStudent();
                        break;
                    case 2:
                        StudentManager.AddSubject();
                        break;
                    case 3:
                        StudentManager.PrintAllStudents();
                        break;
                    case 4:
                        StudentManager.PrintAllSubjects();
                        break;
                    case 5:
                        StudentManager.AddGrade();
                        break;
                    case 6:
                        StudentManager.PrintAllStudentGrades();
                        break;
                }
                Console.WriteLine();
            } while (menu != 0);
        }
    }
}
