from Queue import Queue
que1 = Queue()
que1.enqueue(1)
que1.enqueue(2)
que1.enqueue(3)
que1.enqueue(4)
que1.enqueue(5)
que2 = Queue()
que2.enqueue(6)
que2.enqueue(7)
que2.enqueue(8)
que2.enqueue(9)
que2.enqueue(10)


def test_queue1():
    assert que1.length() == 5

def test_queue2():
    assert que1.back.val == 5 

def test_queue3():
    assert que1.front.next.val == 2

def test_queue4():
    assert que1.toList() == [1,2,3,4,5]

def test_dequeue5():
    que1.dequeue()
    assert que1.length() == 4

def test_dequeue6():
    que1.dequeue()
    assert que1.length() == 3
    assert que1.toList() == [3,4,5]

def test_peek7():
    assert que1.peek() == 3

def test_clear8():
    que1.clear()
    assert que1.toList() == []
    assert que1.length() == 0

def test_absorb9():
    que1.absorb(que2.front)
    assert que1.toList() == que2.toList() == [6,7,8,9,10]
    assert que1.front.val == 6
    assert que1.back.val == 10
    assert que1 != que2
    assert que1.front == que2.front
    assert que1.back == que2.back
    assert que1.length() == que2.length()

