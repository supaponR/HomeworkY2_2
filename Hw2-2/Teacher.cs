using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2_2
{
    class Teacher : Person
    {
        private string employeeID;
        public Teacher(string name, string employeeID)
        : base(name)
        {
            this.employeeID = employeeID;
        }
    }
}
