namespace Threads_in_C_
{
    internal class Program
    {
        static object lockObject = new object(); // For synchronization
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started.");

            // Create and start a thread
            Thread thread1 = new Thread(() =>
            {
                PrintNumbers("Thread 1");
            });
            thread1.Start();

            // Using ThreadPool for efficient thread management
            ThreadPool.QueueUserWorkItem(state => PrintNumbers("ThreadPool Thread"));

            // Synchronization with lock
            Thread thread2 = new Thread(() =>
            {
                lock (lockObject)
                {
                    PrintNumbers("Thread 2 (Locked)");
                }
            });
            thread2.Start();

            // Wait for thread1 and thread2 to complete
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main method finished.");
        }
        static void PrintNumbers(string threadName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{threadName}: {i}");
                Thread.Sleep(500); // Simulate work
            }
        }
    }
}
