package test.structures.linkedlist;
//import src.test.structeres.linkedlist.Node;

class Main
{
	public static void main(String[] args)
	{
//	Node node = new Node("first");
//	node.Data = "First";
	LinkedList linkedList = new LinkedList();
	linkedList.add("First");
	linkedList.add("Second");
	linkedList.add("Third");
	linkedList.add("Third");
	linkedList.add("Forth");
	System.out.println(linkedList.toString());
	System.out.println("I'm here");
	linkedList.remove("First");
	System.out.println(linkedList.toString());


	}
}