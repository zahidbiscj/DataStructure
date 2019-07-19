using System;
using System.Collections.Generic;


namespace DataStructure
{
    public class Student {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class ListSampleCode
    {
        public void Run() {
            List<Student> studentList = new List<Student>();

            Student s = new Student();
            s.Name = "Ashraful Alom Emon";
            s.Age = 23;
            
            studentList.Add(s);

            Student st = new Student();
            st.Name = "Zahid Ahmed ";
            st.Age = 21;
            studentList.Add(st);


            Console.WriteLine("Number of student : "+studentList.Count);

            foreach (var item in studentList)
            {
                Console.WriteLine("\n"+item.Name + "-> AGE : "+item.Age);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
