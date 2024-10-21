using System;

public class Stack<T>
{   
    private ListNode<T>? head;

    public Stack(ListNode<T>? head = null) {
        this.head = head;
    }

    // Returns the value of the top element without removing it
    public T Peek() {
        if (this.head == null) throw new InvalidOperationException("Stack is empty.");
        return this.head.val;
    }

    // Pushes a new element onto the stack
    public void Push(T value) {
        ListNode<T> newNode = new ListNode<T>(value);
        newNode.next = this.head;
        this.head = newNode;
    }

    // Removes and returns the top element of the stack
    public T Pop() {
        if (this.head == null) throw new InvalidOperationException("Stack is empty.");
        ListNode<T> oldHead = this.head;
        this.head = this.head.next;
        oldHead.next = null;
        return oldHead.val;
    }

    // Prints the stack from top to bottom
    public void PrintStack() {
        ListNode<T>? curr = this.head;
        while (curr != null) {
            Console.Write(curr.val);
            if (curr.next != null) {
                Console.Write(" <- ");
            }
            curr = curr.next;
        }
        Console.WriteLine(); // Newline at the end of the stack printout
    }
}