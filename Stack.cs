using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }
    public T Peek() {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        return items[items.Count - 1];
    }
    public bool IsEmpty() {
        return items.Count == 0;
    }

    public int Count() {
        return items.Count;
    }
    public void printStack() {
        Console.WriteLine("Stack content(top to bottom)");
        for (int i = items.Count - 1; i >= 0; i--) {
            Console.WriteLine($"-{items[i]}");
        }
    }
} 
    public class Program {
    public static void Main()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("Apple");
        stack.Push("banana");
        stack.Push("เงาะ");

        stack.printStack();
        Console.WriteLine($"\npeek:{stack.Peek()}");
        Console.WriteLine($"Pop:{stack.Pop()}");

        stack.printStack();
        Console.WriteLine($" \nIsEmpty:{stack.IsEmpty()}");
        Console.WriteLine( $" Count:{stack.Count()}");
    } 





}