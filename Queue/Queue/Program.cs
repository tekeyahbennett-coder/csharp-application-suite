using System;
using System.Collections;

class QueueTest
{
    static void Main(string[] args)
    {
        bool aBoolean = true;
        char aCharacter = '$';
        int anInteger = 34567;
        string aString = "hello";

        Queue myQueue = new Queue();

        myQueue.Enqueue(aBoolean);
        myQueue.Enqueue(aCharacter);
        myQueue.Enqueue(anInteger);
        myQueue.Enqueue(aString);

        Console.WriteLine("---Queue Test---");
        EmptyQueue(myQueue);

        Stack myStack = new Stack();
        myStack.Push("hello!!");
        myStack.Push(null);
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        Console.WriteLine("\nCurrent stack contents (top to bottom):");
        PrintStack(myStack);

        object[] tempArray = myStack.ToArray();
        Array.Reverse(tempArray);

        Queue stackQueue = new Queue();

        foreach (var item in tempArray)
        {
            stackQueue.Enqueue(item);
        }

        Console.WriteLine("\n--- Queue ---");
        EmptyQueue(stackQueue);
    }
   private static void EmptyQueue(Queue queue)
    {
        while (queue.Count > 0)
        {
            Console.WriteLine("Peek: " + (queue.Peek() ?? "null"));
            queue.Dequeue();
        }
    }
   private static void PrintStack(Stack stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item ?? "null");
        }
    }
}
