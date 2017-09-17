package test.structures.linkedlist;

class Node
{
 Object data;

 Node next;

public Node(Object data)
{
this.data = data;
this.next = null;
}

/*
public void Node()
{
this.data = null;
this.next = null;
}
*/

public Object getData()
		{
			return data;
		}
		
		public void setData(Object _data)
		{
			data = _data;
		}
		
		public Node getNext()
		{
			return next;
		}
		
		public void setNext(Node _next)
		{
			next = _next;
		}


}