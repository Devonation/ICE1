namespace GenericLinkedList
{
    internal class Program
    {
        private static CustomLinkedList<Gadget> customLinkedList = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there");
            customLinkedList.AppendItem(new Gadget("Cow","D","T"));
            customLinkedList.AppendItem(new Gadget("Skate","D","T"));
            customLinkedList.AppendItem(new Gadget("House","D","T"));
            Console.WriteLine("Gadgets added!");
            Console.WriteLine(customLinkedList.Display());
            customLinkedList.ReverseList(); 
            Console.WriteLine(customLinkedList.Display());
        }
    }
}
