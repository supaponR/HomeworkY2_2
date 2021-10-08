using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2_2
{
    class Student : Person
    {
        private string studentID;
        public Student(string name, string studentID)
        : base(name)
        {
            this.studentID = studentID;
        }
    }
}
