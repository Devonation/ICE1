using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    internal class CustomLinkedList<T>
    {
        private Node<T> head;

        public CustomLinkedList() { 
        }

        public void AppendItem(T item)
        {
            if (head != null)
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(item);
            }
            else
            {
                head = new Node<T>(item);
            }
        }

        public bool RemoveItem(string name)
        {
            PropertyInfo? propertyInfo = typeof(T).GetProperty("Name");

            if (propertyInfo != null)
            {
                Console.WriteLine("Item does not have 'Name' property");
                return false;
            }
            else
            {
                Node<T> current = head;
                Node<T> previous = null;
                if (current.Data != null)
                {
                    do
                    {
                        if (current.Data.GetType().GetProperty("Name").Equals(name))
                        {
                            previous = current.Next;
                            current = null;
                            return true;
                        }
                        previous = current;
                        current = current.Next;
                    } while (current.Next != null);
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public T FindItem(string name)
        {
            Node<T> current = head;

            if (current.Data != null)
            {
                do
                {
                    if (current.Data.GetType().GetProperty("Name").Equals(name))
                    {
                        return current.Data;
                    }
                    current = current.Next;
                } while (current.Next != null);
                return default;
            }
            else
            {
                return default;
            }
        }
        public string Display()
        {
            string output = "";
            Node<T> current = head;
            output += current.Data.GetType().GetProperty("Name").GetValue(current.Data).ToString() + "\n";
            while (current.Next != null)
            {
                current = current.Next;
                output += current.Data.GetType().GetProperty("Name").GetValue(current.Data).ToString() + "\n";
            }
            return output;
        }

        public void ReverseList()
        {
            //probs make a new custom linked list
            Node<T> current = head;

            while (current.Next != null)
            {
                Node<T> temp = head;
                head = current;
                current = current.Next;
            }
        }
    }
}
