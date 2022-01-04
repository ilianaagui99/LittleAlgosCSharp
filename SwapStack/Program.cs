using System;
using System.Collections.Generic;

namespace SwapStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stack stack2 = new Stack();
            Stack stack3 = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Display();

            List<int> stackList = new List<int>();
            int index= 0;
            while(stack.head != null)
            {
                stackList.Add(stack.Pop());
                index++;
            }

            for(int i = index-1; i > 0; i-=2)
            {
                int temp = stackList[i];
                stackList[i] = stackList[i-1];
                stackList[i-1] = temp;
                
            }
    
            index--;
            while(index >= 0)
            {
                stack2.Push(stackList[index]);
                index--;
            }
            Console.WriteLine("---------");

            stack2.Display();
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
        

        public Stack()
        {
            head = null;
            
        }

        public void Push(int value)
        {

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
