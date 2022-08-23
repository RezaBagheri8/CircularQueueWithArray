using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueWithArray
{
    public class CircularQueue
    {
        public int[] queue;
        public int size;
        public int front;
        public int rear;

        public CircularQueue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            queue = new int[sizeOfQueue];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full");
            }
            else
            {
                if (front == -1)
                {
                    front++;
                }

                rear = (rear + 1) % size;
                queue[rear] = item;

            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Console.WriteLine(queue[front]);

                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % size;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {

                if (rear >= front)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine(queue[i]);
                    }
                }
                else
                {
                    for (int i = front; i <= (queue.Length - 1); i++)
                    {
                        Console.WriteLine(queue[i]);
                    }
                    for (int i = 0; i <= rear; i++)
                    {
                        Console.WriteLine(queue[i]);
                    }
                }
            }
        }

        public bool IsEmpty()
        {
            if ((front == -1 && rear == -1) || front > rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (((rear + 1) == size && front == 0) || (front - 1) == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
