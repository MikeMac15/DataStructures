class Node:
    def __init__(self, val) -> None:
        self.val = val
        self.next = None
        self.prev = None
    
    def __str__(self) -> str:
        return f'{self.val}'