namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine();
            Task1 task1 = new Task1();
            task1.TestTask1();
            Console.WriteLine();

            Console.WriteLine("Task 2");
            Console.WriteLine();
            Task2 task2 = new Task2();
            task2.TestTask2();
            Console.WriteLine();

            Console.WriteLine("Task 3");
            Console.WriteLine();
            Task3 task3 = new Task3();
            task3.TestTask3();
            Console.WriteLine();

        }
    }
}
