using System;

public class Queue<T>
{
    private ListNode<T>? head;
    public int length;

    public Queue(ListNode<T>? head = null) {
        this.head = head;
        this.length = 0;
    }

    // Returns the value at the front of the queue without removing it
    public T Peek() {
        if (this.head == null) throw new InvalidOperationException("Queue is empty.");
        return this.head.val;
    }

    // Adds a new node to the end of the queue
    public void Enqueue(T val) {
        this.length++;
        ListNode<T> node = new ListNode<T>(val);
        ListNode<T>? curr = this.head;
        if (curr == null) {
            this.head = node;    
        } else{
            while (curr.next != null){
                curr = curr.next;
            }
            curr.next = node;
        }
    }

    // Removes and returns the node at the front of the queue
    public T Dequeue() {
        if (this.head == null) throw new InvalidOperationException("Queue is empty.");
        ListNode<T> oldHead = this.head;
        this.head = this.head.next;
        oldHead.next = null;
        return oldHead.val;
    }

    // Prints the queue from front to back
    public void PrintQueue() {
        ListNode<T>? curr = this.head;
        while (curr != null) {
            Console.Write(curr.val);
            if (curr.next != null) Console.Write(" -> ");
            curr = curr.next;
        }
        Console.WriteLine(); // Newline at the end of the queue printout
    }
}

