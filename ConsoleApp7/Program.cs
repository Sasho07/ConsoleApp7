namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);

            Console.WriteLine("Оригинален списък:");
            list.PrintList();

            list.Reverse();

            Console.WriteLine("Обърнат списък:");
            list.PrintList();
        }
    }
}
