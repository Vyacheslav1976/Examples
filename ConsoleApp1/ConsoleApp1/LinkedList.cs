using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ex_class1 = new Class1();
            ex_class1.Str1 = "stroka1";
            String ss = "ssssss";
            Console.WriteLine(ex_class1.Str1 + ss);
            
            LinkedList<String> List1 = new LinkedList<String>();

            List1.add("First");
            List1.add("Second");
            List1.add("Third");
            List1.add("Forth");
            Console.WriteLine(List1.ToString());
                        List1.remove("Third");
            Console.WriteLine(List1.ToString());
            List1.add("Six");
            List1.add("Six");
            Console.WriteLine(List1.ToString());
            List1.remove("Six");
            Console.WriteLine(List1.ToString());
            List1.add("Seven");
            List1.add("Seven");
            List1.add("Seven");
            Console.WriteLine(List1.ToString());
            List1.remove("Seven");
            Console.WriteLine(List1.ToString());

            Console.Read();
        }
    }

    class Class1
    {
        private String str1;
        public string Str1 { get => str1; set => str1 = value; }
    }

    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {

        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

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
        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            count++;
        }

        public void remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;
            //Node<T> node = new Node<T>(data);

            while (current != null)
            {
                if (current.Data.Equals(data))
                { 

                    if (previous == null)  // если первый элемент
                    {
                        head = current.Next;
                    }
                    else  //если в середине ли конце
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    count--;
                }

                previous = current;
                current = current.Next;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



}
