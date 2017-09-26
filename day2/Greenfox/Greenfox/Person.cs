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
    }

    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void Introduce()
        {
                Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3}, who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "School Of Life";
            skippedDays = 0;
        }
    }
}
