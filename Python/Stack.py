from Node import Node

class Stack:
    def __init__(self):
        self.top = None
        self.bottom = None
        self.__length = 0

    def peek(self):
        return self.top.val
    
    def push(self,val:any)->None:
        new_node:Node = Node(val)
        self.__length += 1
        if self.top == None:
            self.top = new_node
        else:
            if self.bottom == None:
                self.bottom = self.top
                self.top = new_node
                self.top.prev = self.bottom
                self.bottom.next = self.top
            else:
                new_node.prev = self.top
                self.top.next = new_node
                self.top = new_node

    def pop(self)->any:
        if self.top == None:
            return None
        
        result_node = self.top
        self.__length -= 1
        if not self.top.prev:
            self.top = None
            return result_node.val
        self.top = self.top.prev
        self.top.next = None
        result_node.prev = None
        if self.top == self.bottom:
            self.bottom = None
        return result_node.val
        
    def length(self)->int:
        return self.__length
    
    def clear(self):
        curr:Node = self.top
        while curr:
            temp = curr.prev
            curr.next = None
            curr.prev = None 
            curr = temp
        self.top = None
        self.bottom = None
        self.__length = 0

    def absorb(self, other) -> None:
        self.top = other.top
        self.bottom = other.bottom
        self.__length = other.length()

    def toList(self) -> list:
        l1 = []
        if not self.bottom and not self.top:
            return l1
        curr = self.top

        while curr:
            l1.append(curr.val)
            curr = curr.prev
        
        return l1




    def find(self):
        pass
    def remove(self):
        pass
    def bump(self):
        pass
        '''bumps item up n times in stack'''
    def prioritize(self):
        pass
        '''bumps item up to top of stack'''
