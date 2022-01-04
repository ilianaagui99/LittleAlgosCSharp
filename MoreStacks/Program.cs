using System;
using System.Collections.Generic;

namespace MoreStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stack stackOdd = new Stack();
            Stack stackEven = new Stack();
            Stack stack2Odd = new Stack();
            Stack stack2Even = new Stack();
            Stack stackFinal = new Stack();


            stack.Push(7);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            stack.Display();
            
            //seperate evens and odds
            //int count = 1;
            while (stack.size != 0)
            {
                int num = stack.Pop();
                if(num % 2 == 0)
                {
                    stackEven.Push(stack.Pop());
                }
                else
                {
                    stackOdd.Push(stack.Pop());
                }
                
            }

            //reverse them
            //int numA = 0;
            while(stackEven.size != 0)
            {
                stack2Even.Push(stackEven.Pop());
                //numA++;
            }

            //int numB = 0;
            while(stackOdd.size != 0)
            {
                stack2Odd.Push(stackOdd.Pop());
                //numB++;
            }

            //put into final stack
            //int numAA = 0;
            while(stack2Odd.size != 0)
            {
                stackFinal.Push(stack2Odd.Pop());
               // numAA++;
            }

            //int numBB = 0;
            while(stack2Even.size != 0)
            {
                stackFinal.Push(stack2Even.Pop());
                //numBB++;
            }


            Console.WriteLine("---------");
            stackFinal.Display();

            // Console.WriteLine("---------");
            // stackEven.Display();
            // Console.WriteLine("---------");
            // stackOdd.Display();
            // stack.Pop();
            // stack.Pop();
            // Console.WriteLine("---------");
            // stack.Display();
        }
    public class StackNode
    {   
        public int value;
        public StackNode next;

        public StackNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class Stack
    {
        public StackNode head;
        public int size;

        public Stack()
        {
            head = null;
            size = 0;
            
        }

        public void Push(int value)
        {
            this.size ++;
            StackNode newNode = new StackNode(value);
            if (head == null)
            {
                head=newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        
        }

        public int Pop()
        {
            this.size --;
            int peek = -1;
            if (head != null)
            {
                peek = head.value;
                head = head.next;
            }

            return peek;

        }

        public void Display(){
            var runner = this.head;
            while(runner != null){
                Console.WriteLine(runner.value);
                runner = runner.next;
            }
        }

}
        
}
}
