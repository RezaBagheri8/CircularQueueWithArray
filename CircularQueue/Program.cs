using CircularQueueWithArray;

var queue = new CircularQueue(10);

queue.Enqueue(9);
queue.Enqueue(87);

queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

queue.Enqueue(87);

queue.Dequeue();




Console.WriteLine("-------------------------------------");

queue.Print();