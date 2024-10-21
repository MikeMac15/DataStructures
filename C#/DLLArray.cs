using System;
using System.ComponentModel;

public class DLLArray<T> {
    DoubleyListNode<T>? head;
    DoubleyListNode<T>? tail;
    int length;
    public DLLArray(){
        this.head = null;
        this.length = 0;
    }

    public void Clear(){
        this.head = null;
        this.tail = null;
        this.length = 0;
    }

    public void Push(T val){
        DoubleyListNode<T> newNode = new DoubleyListNode<T>(val);
        this.length++;
        if (this.head == null || this.tail == null){
            this.head = newNode;
            this.tail = this.head;
            return;
        }
        newNode.prev = this.tail;
        this.tail.next = newNode;
        this.tail = this.tail.next;
    }

    public T Pop(){
        T outVal;
        if (this.tail == null || this.length == 0) throw new Exception("LLArray Empty");
        if (this.tail.prev == null) throw new Exception("Data Corruption");
        if (this.length == 1 && this.head != null) {
            outVal = this.head.val;
            this.Clear();
            return outVal;
        }

        outVal = this.tail.val;
        this.tail = this.tail.prev;
        this.tail.next = null;
        this.length--;
        return outVal;
    }

    public void Shift(T val){
        DoubleyListNode<T> newHead = new DoubleyListNode<T>(val);
        length++;
        if (this.head == null){
            this.head = newHead;
            this.tail = newHead;
            return;
        }
            DoubleyListNode<T> oldHead = this.head;
            newHead.next = oldHead;
            oldHead.prev = newHead;
            this.head = newHead;
            return;

    }

    public T Unshift(){
        T outVal;
        if (this.head == null) throw new Exception("LLArray Empty");
        if (this.length == 1 || this.head.next == null) {
            outVal = this.head.val;
            this.Clear();
            return outVal;
        }
        outVal = this.head.val;
        DoubleyListNode<T> newHead = this.head.next;
        newHead.prev = null;
        this.head = newHead;
        this.length--;
        return outVal;
    }

    public void Remove(DoubleyListNode<T> node){
        if (this.head == null) throw new Exception("Node not in list because list is empty.");
        if (this.head == node){
            if (node.next == null) this.Clear();
            else {
                this.head = node.next;
                node.next = null;
                this.head.prev = null;
            }
            return;
        } 
        if (this.tail == node){
            this.Pop();
            return;
        }
        DoubleyListNode<T> curr = this.head;
       
        while (curr != null){
            if (curr == node){
                if (curr.prev != null) curr.prev.next = curr.next;
                if (curr.next != null) curr.next.prev = curr.prev;
                
                node.next = node.prev = null;
                return;
            }     
            if (curr.next != null){
                curr = curr.next;
            } else {
                break;
            }
        }
        throw new Exception("Node not found.");

        
    }

    

}