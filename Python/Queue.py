from Node import Node
class Queue:
    def __init__(self) -> None:
        self.front = None
        self.back = None
        self._length = 0

    def enqueue(self, val:any) -> None:
        new_node = Node(val)
        self._length += 1
        if self.front == None:
            self.front = new_node
            return
        
        if self.back == None:
            self.front.next = new_node
            self.back = new_node
            new_node.prev = self.front
        else:
            self.back.next = new_node
            new_node.prev = self.back
            self.back = new_node

    def dequeue(self)-> any:
        self._length -= 1
        if self.back == None and self.front == None:
            return None
        if self.back == None:
            temp = self.front.val
            self.front = None
            return temp
        temp = self.front
        temp.next.prev = None
        self.front = temp.next
        temp.next = None
        return temp.val
            
    def length(self) -> int:
        return self._length
    
    def toList(self) -> list:
        list1 = []
        curr = self.front

        while curr != None:
            list1.append(curr.val)
            curr = curr.next
        return list1
    
    def peek(self) -> any:
        return self.front.val
    
    def clear(self) -> None:
        curr = self.front

        while curr:
            temp = curr.next
            curr.prev = None
            curr.next = None
            curr.val = None
            curr = temp
        self.front = None
        self.back = None
        self._length = 0

    def absorb(self, other_front:Node) -> None:
        self.front = other_front
        curr = self.front
        self._length = 1
        while curr.next:
            curr = curr.next
            self._length +=1
        
        self.back = curr