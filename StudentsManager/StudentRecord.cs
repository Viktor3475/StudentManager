using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    internal class StudentRecord
    {
        private double _grade;

        public Subject Subject { get; set; }
        public double Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new Exception("Invalid grade!");
                }
                _grade = value;
            }
        }
    }
}
