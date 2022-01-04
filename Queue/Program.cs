using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            SLQueue queue = new SLQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Display();
            Console.WriteLine("--------");
            queue.Dequeue();
            queue.Display();

        }
        
        public class SLNode
        {   
            public int value;
            public SLNode next;

            public SLNode(int value)
            {
                this.value = value;
                this.next = null;
            }
        }
        
        public class SLQueue
        {
            public SLNode head;
            public SLNode tail;
            //public int size;

            public SLQueue()
            {
                head = null;
                tail = null;
                //size = 0;
                
            } 
        

        public void Enqueue(int value)
        {
           // this.size ++;
            SLNode newNode = new SLNode(value);
            if (head == null)
            {
                head=newNode;
                tail = newNode;
                return;
            }

            tail.next = newNode;
            tail = newNode;
        }
        public int Dequeue()
        {
           // this.size --;
            int peek = -1;
            if (head != null)
            {
                // if(size == 1)
                // {

                // }
                peek = head.value;
                head = head.next;
            }

            return peek;

        }
        public void Display()
        {
            var runner = this.head;
            while(runner != null)
            {
                Console.WriteLine(runner.value);
                runner = runner.next;
            }
        }
        }
    }

}
