﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2_1
{
    class Teacher : Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID)
        : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }

    }
}
