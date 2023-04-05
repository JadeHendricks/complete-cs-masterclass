using System;
using System.Collections;

namespace CollectionsPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTablesExample();
            HashTablesChallenge();
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
    }
}
