using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2_2
{
    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        
    }
}
