"""
 Insert Node at the end of a linked list 
 head pointer input could be None as well for empty list
 Node is defined as
 
 class Node(object):
 
   def __init__(self, data=None, next_node=None):
       self.data = data
       self.next = next_node
 
 return back the head of the linked list in the below method
"""

def Insert(head, data):
    if head == None:
        return Node(data,None)
    temp = head
    while temp != None:
        prev_node = temp
        temp = temp.next
    prev_node.next = Node(data,None)
    return head
