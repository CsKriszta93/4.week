using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public void Introduce(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

            Console.WriteLine("Hi, I'm {0} , a {1} year old {2}.", name, age, gender);

        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment.");

        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
    
        }

    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;
    }

    }
}
