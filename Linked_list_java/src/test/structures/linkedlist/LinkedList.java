package src.test.structures.linkedlist;

//import src.test.structures.linkedlist.Node;

class LinkedList<T>
{
            Node<T> head;
            Node<T> tail;
	int count;

         public override String ToString()
        {
            String obj_string = "";
            Node<T> current = head;
            while (current != null)
            {
                obj_string = obj_string + current.Data.ToString() + " ";
                current = current.Next;
            }
            return obj_string;
        }


}