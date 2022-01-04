using System;

namespace ClassStack
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
            while(stack.head != null)
            {
                stack2.Push(stack.Pop());
            }

            while(stack2.head != null)
            {
                stack3.Push(stack2.Pop());
            }
            Console.WriteLine("---------");

            stack3.Display();
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
