using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructure
{
    class QueueSampleCode
    {
        public void Run() {
            Queue myQueue = new Queue();
            myQueue.Enqueue("Zahid");
            myQueue.Enqueue("Ahmed");
  
            myQueue.Dequeue();

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);

            }
        }
    }
}
