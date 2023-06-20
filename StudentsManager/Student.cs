using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    internal class Student
    {
        private int studentRecordsCount = 0;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public StudentRecord[] StudentRecords { get; set; } = new StudentRecord[200];

        public void AddStudentRecord(Subject subject, double grade)
        {
            StudentRecords[studentRecordsCount++] = new StudentRecord
            {
                Subject = subject,
                Grade = grade
            };
        }

        public void PrintAllGrades(Subject subject)
        {
            int count = 0;
            double sum = 0.0;
            for(int i = 0; i < studentRecordsCount; i++)
            {
                var record = StudentRecords[i];
                if (record.Subject.Id == subject.Id)
                {
                    sum += record.Grade;
                    count++;
                    Console.WriteLine($"{record.Grade}");
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Average: {sum / count}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{Id}. {FirstName} {MiddleName} {LastName}");
        }
    }
}
