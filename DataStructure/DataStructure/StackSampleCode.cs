using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructure
{
    class StackSampleCode
    {
        public void Run() {

            Stack myStack = new Stack();
            myStack.Push("zahid");
            myStack.Push("1");
            myStack.Push("2");
            myStack.Pop();

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            if(myStack.Contains("zahid"))
            {
                Console.WriteLine("Your name is found");
            }
            else
            {
                Console.WriteLine("Your name is not found");
            }
        }
    }
}
