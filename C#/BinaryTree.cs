using System;

public class BinaryTree<T> {
    public TreeNode<T>? head;
    public BinaryTree(TreeNode<T>? head = null){
        this.head = head;
    }

    public int Count(){
        if (this.head == null) return 0;
        int count = 0;
        Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>(new[] {this.head});
        while (stack.Count > 0){
            TreeNode<T> curr = stack.Pop();
            count++;
            if (curr.left != null){
                stack.Push(curr.left);
            }
            if (curr.right != null){
                stack.Push(curr.right);
            }

        }
        return count;
    }

    public static bool Compare(TreeNode<T>? a, TreeNode<T>? b){
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        if (!EqualityComparer<T>.Default.Equals(a.val,b.val)) return false;
        return Compare(a.left, b.left) && Compare(a.right, b.right); 
    }

}