using LinkedListLibrary;
using QueueInheritanceLibrary;

namespace queueInheritanceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueInheritance queue = new QueueInheritance();

            // Create objects to store in the queue
            bool aBoolean = true;
            char aCharacter = '$';
            int anInteger = 34567;
            string aString = "hello";

            // Use method Push to add items to the queue
            queue.Enqueue(aBoolean);
            queue.Display();
            queue.Enqueue(aCharacter);
            queue.Display();
            queue.Enqueue(anInteger);
            queue.Display();
            queue.Enqueue(aString);
            queue.Display();

            // Use method Dequeue to remove items from queue
            object removedObject = null;

            // Remove items from queue
            try
            {
                while (true)
                {
                    removedObject = queue.Dequeue();
                    Console.WriteLine($"{removedObject} dequeued\n");
                    queue.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                // If exception occurs, write queue trace here
                Console.Error.WriteLine(emptyListException.StackTrace);
            }
        }
    }
}