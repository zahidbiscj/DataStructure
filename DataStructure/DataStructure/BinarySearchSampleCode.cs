using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BinarySearchSampleCode
    {
        public void Run() {
            int[] inputArray = { 1, 2, 4, 5, 9 };
            int key = 9, min = 0, max = inputArray.Length-1,flag=0;

            while (min <= max) {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    Console.WriteLine("Element is present at - "+mid);
                    flag = 1; break;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else { min = mid + 1; }
            }
            if (flag == 0) { Console.WriteLine("Not found"); } 
        }
    }
}
