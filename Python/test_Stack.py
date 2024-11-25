from Stack import Stack

stack1 = Stack()
stack2 = Stack()



def test_push():
    stack1.push(1)
    stack1.push(2)
    stack1.push(3)
    stack1.push(4)
    stack1.push(5)
def test_length():
    assert stack1.length() == 5
def test_pop():
    assert stack1.pop() == 5
    assert stack1.pop() == 4
    assert stack1.pop() == 3
    assert stack1.length() == 2
def test_peek():
    assert stack1.peek() == 2
def test_toList():
    assert stack1.length() == len(stack1.toList())
    assert  stack1.toList() == [2,1]
def test_clear():
    stack1.clear() 
    assert stack1.toList() == []
    assert stack1.length() == 0
def test_absorb():
    stack2.push(6)
    stack2.push(7)
    stack2.push(8)
    stack2.push(9)
    stack2.push(10)
    assert stack2.length() == 5
    stack1.absorb(stack2)
    assert stack1.toList() == stack2.toList() == [10,9,8,7,6]
    assert stack1.length() == stack2.length()