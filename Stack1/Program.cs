using System;
using System.Collections.Generic;

namespace MoreStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(7);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine(stack.Top());
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Contains(3));


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

        public int Top()
        {
            var runner = this.head;
            while(runner.next != null){
                //Console.WriteLine(runner.value);
                runner = runner.next;
            }
            return runner.value;
        }

        public bool isEmpty()
        {
            if(head == null)
            {
                return true;
            }
            return false;
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
        public bool Contains(int value)
        {
            var runner = this.head;
            while(runner != null){
                if(runner.value == value){
                    return true;
                }
                runner = runner.next;
            }
            return false;
        }
        public int Count(){
            var runner = this.head;
            int count = 0;
            while(runner != null){
                count++;
                runner = runner.next;
            }
            return count;
        }

}
        
}
}
