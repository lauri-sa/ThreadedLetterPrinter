namespace Palautustehtava_1
{
    internal class Palautustehtava1
    {
        static void Main(string[] args)
        {
            // Create three new threads that execute the PrintLetters method with the given parameter.
            Thread threadA = new Thread(() => PrintLetters('A'));
            Thread threadB = new Thread(() => PrintLetters('B'));
            Thread threadC = new Thread(() => PrintLetters('C'));

            // Start thread A and wait for it to finish before starting thread B.
            threadA.Start();
            threadA.Join();

            // Start thread B and wait for it to finish before starting thread C.
            threadB.Start();
            threadB.Join();

            // Start thread C and wait for it to finish before the program exits.
            threadC.Start();
            threadC.Join();

            // Method that prints the given letter 100 times, with a running number for each.
            static void PrintLetters(char letter)
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine($"{letter}{i}");
                }
            }
        }
    }
}