using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class ArraySampleCode
    {
        public void Run() {

            string[] topic = new string[]{ "Array", "Linked list","Sorted List","Stack","Queue"};

            Array.Sort(topic);

            foreach (string item in topic)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}