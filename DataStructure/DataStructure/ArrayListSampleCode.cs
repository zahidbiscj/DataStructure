using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class ArrayListSampleCode
    {
       public void Run() {
            ArrayList myList = new ArrayList();

            myList.Add("Zahid");
            myList.Add(123);
            myList.Add(DateTime.Now);
            myList.Remove(123);
            myList.Insert(0, "Zahid Ahmed");
            myList.Reverse();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        
    }
}
