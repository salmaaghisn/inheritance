using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace per8
{
    class Person
    {
        private string name;
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and Age : {1}", Name, Age);
        }
    }
}
