using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace CollectionsPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTablesExample();
            HashTablesChallenge();
            DictionariesExample();
            StacksExamples();
            Console.Read();
        }

        public static void HashTablesExample()
        {
            //student registration system
            //creating a hastable instance
            // a hastable is basically a collection of dictionary entries
            //whenever we create a new entry to a hastable a new dictionary will be create for us and used.
            Hashtable studentTable = new Hashtable();

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 79);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 55);

            //adding students to the hashtable
            //key = id and value is the student itself (the value will be of type OBJECT)
            studentTable.Add(student1.Id, student1);
            studentTable.Add(student2.Id, student2);
            studentTable.Add(student3.Id, student3);
            studentTable.Add(student4.Id, student4);

            //retrieving a student and casting the value object in to student by known ID
            Student storedStudent1 = (Student)studentTable[student1.Id];
            Student storedStudent2 = (Student)studentTable[student2.Id];
            Student storedStudent3 = (Student)studentTable[student3.Id];

            //getting individual students
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent2.Id, storedStudent2.Name, storedStudent2.GPA);
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent3.Id, storedStudent3.Name, storedStudent3.GPA);

            Console.WriteLine("******************************************************");

            Console.WriteLine("With Casting");
            //looping through our hashtable and retriving all values
            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }
            Console.WriteLine("******************************************************");
            Console.WriteLine("Without Casting");

            //another way to loop through a dictionary - without casting
            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }

            Console.WriteLine("******************************************************");
        }

        public static void HashTablesChallenge()
        {
            //write a program that will iterate through each element of the students array and insert them into a hastable
            //if the student already exists skip it and display the following error: "Sorry, A student with the same ID already exists"

            //defining our hastable
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student student in students)
            {
                if (!studentsTable.ContainsKey(student.Id))
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Student with ID:{0} wa added!", student.Id);
                } else
                {
                    Console.WriteLine("Sorry, A student with the same ID already exists ID:{0}", student.Id);
                }
            }

            Console.WriteLine("************************************");
        }
    
        public static void DictionariesExample()
        {
            //example of a database of employees
            //internally these vlaues will all be set at a number weven if we don't decalre an id
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            //the generic verison of a hashtabe is a dictionary
            //creating a dictionary - Dictionary<TKey, TValue> (we need to define the type of the key and value)
            //Example
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            //looping through employees array and add it to the employees directory - key being the role and value being the employee themeselves
            foreach (Employee employee in employees)
            {
                employeesDirectory.Add(employee.Role, employee);
            }

            //checking if the key exists
            string key1 = "CEO";
            string key2 = "Lead Developer";

            if (employeesDirectory.ContainsKey(key1))
            {
                //getting data from a dictionary
                Employee ceo = employeesDirectory[key1];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: 2", ceo.Name, ceo.Role, ceo.Salary);
                if (employeesDirectory.ContainsKey(key2))
                {
                    //getting data from a dictionary
                    Employee leadDeveloper = employeesDirectory[key2];
                    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: 2", leadDeveloper.Name, leadDeveloper.Role, leadDeveloper.Salary);
                }
            } else
            {
                Console.WriteLine("The key that you have entered. Does not exist.");
            }

            Console.WriteLine("***********************************************");

            //using TryGetValue()
            //using TryGetValue() it returns true if the operation was successful and false otherwise
            Employee result = null;

            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved - TryGetValue() example");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            } else
            {
                Console.WriteLine("The key entered does not exist");
            }

            Console.WriteLine("***********************************************");

            Console.WriteLine("ElementAt EXAMPLE = ");
            //using ElementAt() to loop over dictionaries
            //count give the number of key value pairs there are in a dictionary
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return the keyvalue pair store in index 1 - or what ever the ounter is at
                //get the key value pairs. ElementAt returns a keyvalue pair that we need to store
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                //print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                //storing the properties into a employee object
                //value gets the value inside of the key value pair
                //key here is a string and value is the employee itself
                Employee employeeValue = keyValuePair.Value;

                //printing the properties of the employee objecy
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }
            Console.WriteLine("***********************************************");

            //update a certain key in a dictionary
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/key {0} was updated!", keyToUpdate);
            } else
            {
                Console.WriteLine("No employee found with this key: {0}", keyToUpdate);
            }

            Console.WriteLine("***********************************************");

            //remove an item from our dictionary
            string keyToRemove = "Intern";
            //remove here returns a boolean if something was removed so we can use it here inside of the if statement
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed!", keyToRemove);
            } else
            {
                Console.WriteLine("No employee found with this key: {0}", keyToRemove);
            }

            Console.WriteLine("***********************************************");
        }
    
        public static void StacksExamples()
        {
            //a stack could hold any type of Object(strings, your own classes etc) but only one type per stack!!(bc it's a  generic)
            //defining a stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using push()
            //then using peak to see what is the top level entry

            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            stack.Push(3);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            //checking if there is things in the stack before doing trying to remove anything
            if (stack.Count > 0)
            {
                int myStackedItem = stack.Pop(); //return the object on top othe stack
                Console.WriteLine("Popped item: {0}", myStackedItem);
                Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            }
            Console.WriteLine("***********************************************");

            //while loop that deletes all the items from the stack
            //THIS DOES NOT FOLLOW THE LIFO
            while(stack.Count > 0)
            {
                //pop will retrun the element that was removed fromt he stack
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());
                //print the stack count
                Console.WriteLine("Current stack count is: {0}", stack.Count);
            }

            Console.WriteLine("***********************************************");

            //adding numbers to a stack
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //defining a stack of int
            Stack<int> myIntStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are :");
            foreach(int number in numbers)
            {
                //print it
                Console.Write(number + " ");
                //push it into our stack(add)
                myIntStack.Push(number);
            }

            Console.WriteLine("***********************************************");

            //reverse an array of values with a stack
            Console.WriteLine("The numbers in reverse :");
            //as long as the stack is not empty
            while(myIntStack.Count > 0)
            {
                //pop it and store it in a variable
                int number = myIntStack.Pop();
                //print the value we popped
                Console.Write(number + " ");
            }
        }
    }
}
