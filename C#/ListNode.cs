using System;
public class DoubleyListNode<T>
{
    public T val;
    public DoubleyListNode<T>? next;
    public DoubleyListNode<T>? prev;
  
    public DoubleyListNode(T value, DoubleyListNode<T>? next = null, DoubleyListNode<T>? prev = null){
        this.val = value; 
        this.next = next;  
        this.prev = prev;
    }
}

public class TreeNode<T> {
    public T val;
    public TreeNode<T>? left;
    public TreeNode<T>? right;
    public TreeNode(T val, TreeNode<T>? left = null, TreeNode<T>? right = null){
        this.val = val;
        this.left = left;
        this.right = right;
    }

}

public class ListNode<T>
{
    public T val;
    public ListNode<T>? next;

    public ListNode(T val, ListNode<T>? next = null) {
        this.val = val;
        this.next = next;
    }
}