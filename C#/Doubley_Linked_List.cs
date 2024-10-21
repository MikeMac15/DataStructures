using System;

public class DoubleyLinkedList<T>
{
    private DoubleyListNode<T>? head;
    public int length;
    public DoubleyLinkedList(){
        this.length = 0;
        this.head = null;
    }

    public void prepend(T item){
        this.length++;

        if (this.head == null){
            this.head = new DoubleyListNode<T>(item);
        }

        DoubleyListNode<T> node = new DoubleyListNode<T>(item);

        node.next = this.head;
        this.head.prev = node;
        this.head = node;
    }
    public void append(T item){
        this.length++;
        if (this.head == null){
            prepend(item);
            return;
        }
        DoubleyListNode<T> curr = this.head;
        DoubleyListNode<T> node = new DoubleyListNode<T>(item);

        while (curr.next != null){
            curr = curr.next;
        }
        curr.next = node;
        node.prev = curr;
    }
    public void insert_at(T item, int idx){
        if (idx > this.length){
            throw new Exception("oh no");
        } else if (idx == 0 || this.head == null){
            prepend(item);
            return;
        } else if (idx == this.length){
            append(item);
            return;
        }
        DoubleyListNode<T> curr = this.head;
        for (int i = 0; i < idx; i++){
            if (curr.next == null){
                throw new Exception("oh no");
            }
            curr = curr.next;
        }
        DoubleyListNode<T> node = new DoubleyListNode<T>(item);
        node.next = curr;
        node.prev = curr.prev;
        curr.prev = node;
        curr.prev.next = node;
    }

    public void remove(){

    }
    public void get(){

    }
    public void remove_at(){

    }


}