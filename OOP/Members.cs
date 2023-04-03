using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Members
    {
        //member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member public field
        public int age;

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member property that exposes jobTitle safely = "properties start with a capital letter"
        public string JobTitle {
            get 
            {
                return jobTitle;
            } 
            set
            {
                this.jobTitle = value;
            } 
        }

        //public memeber method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            } else
            {
                Console.WriteLine("Hi my name is {0}, my job title is {1}, I am {2} years old", memberName, jobTitle, age);
            }
        }

        private void sharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member finalizer destructor - a class can only have 1 destructor
        //the finalizer cannot be inherited or called, it's only there for this specific class
        //whenever this class runs out of scope this finalizer will be called (almost like an ngOnDestroy)
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of member object");
        }
    }
}
