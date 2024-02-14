var queue = new PriorityQueue<string, int>();
queue.Enqueue("John", 2);
queue.Enqueue("Jane", 3);
queue.Enqueue("Joe", 5);
queue.Enqueue("Jill", 4);
queue.Enqueue("Jack", 1);

queue.Remove("John", out var removedItem, out var priority); // `Remove` is new in .NET 9
Console.WriteLine($"Removed: {removedItem} with priority {priority}");

while (queue.Count > 0)
{
    var item = queue.Dequeue();
    Console.WriteLine(item);
}