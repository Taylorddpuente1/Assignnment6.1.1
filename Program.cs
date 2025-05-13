using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MyLinkedList
{
    class Node
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        public int data;
        public Node next;
        // Node newnode= new Node
        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }
    }
    class HouseList
    {
        private Node head;
        private Node tail;
        private int size;
        private int Size
        {
            get { return size; }
        }
        public HouseList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public bool SearchHouse(int houseNumber, out int index)
        {
            Node temp = head;
            int i = 1;
            while (temp != null)
            {
                if (temp.data == houseNumber)
                {
                    index = i;
                    return true;
                }
                temp = temp.next;
                i++;
            }
            index = -1;
            return false;
        }
        static void Main(string[] args)
        {
            HouseList houseList = new HouseList();

            houseList.head = new Node(1908, null);
            houseList.head.next = new Node(1902, null);
            houseList.head.next.next = new Node(1903, null);

            Console.WriteLine("Enter house number to search");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            if (houseList.SearchHouse(searchNumber, out int index))
            {
                Console.WriteLine($"House found at index:  {index}");
            }
            else
            {
                Console.WriteLine("House not found");
            }
        }
    }
}
