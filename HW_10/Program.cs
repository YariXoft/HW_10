using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"Пiсля обмiну: a = {a}, b = {b}");

        double c = 3.5;
        double d = 9.8;
        Console.WriteLine($"c = {c}, d = {d}");
        Swap(ref c, ref d);
        Console.WriteLine($"Пiсля обмiну: c = {c}, d = {d}");

        PriorityQueue<string> priorityQueue = new PriorityQueue<string>();
        priorityQueue.Enqueue("Елемент 1");
        priorityQueue.Enqueue("Елемент 2");
        priorityQueue.Enqueue("Елемент 3");

        string highestPriorityItem = priorityQueue.Dequeue();
        Console.WriteLine($"Елемент з найвищим прiоритетом: {highestPriorityItem}");

        int count = priorityQueue.Count;
        Console.WriteLine($"Кiлькiсть елементiв у черзi: {count}");
    }

    static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }

    class PriorityQueue<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
            items.Sort(); // Сортувати - як простий спосіб приоритетної чергі
        }

        public T Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Черга порожня");

            T highestPriorityItem = items[0];
            items.RemoveAt(0);
            return highestPriorityItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Черга порожня");

            return items[0];
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}
