package test.structures.linkedlist;

//import src.test.structures.linkedlist.Node;

class LinkedList //implements Iterable<T>
{
            Node head;
            Node tail;
	int count;

         public void add(Object data)
        {
         Node node = new Node(data);
		if (head == null)
		{
			head = node;
		}
		else
		{
			tail.setNext( node);
		}
	tail = node;
	count++;

	}

public void remove(Object data)
{
	Node current = head;
	Node previous = null;

	while (current != null)
	{
	if (current.getData().equals(data))
	{

		if (previous == null) // если первый элемент
			{
			head = current.getNext();
			}
		else //если в середине ли конце
		{
			previous.setNext( current.getNext());
		if (current.getNext() == null)
			{	
			tail = previous;
			}
		}
		count--;
	}

previous = current;
current = current.getNext();
}
}




         public String toString()
        {
            String obj_string = "";
            Node current = head;
            while (current != null)
            {
                obj_string = obj_string + current.getData().toString() + " ";
                current = current.getNext();
            }
            return obj_string;
        }


}