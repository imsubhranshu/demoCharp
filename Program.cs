using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Operatiion.add(10);
            // Operatiion.add(20);
            // Operatiion.add(30);
            // Operatiion.add(40);
            // Operatiion.add(50);

            Operatiion.addToHead(0);
            Operatiion.addToHead(1);
            Operatiion.addToHead(2);
            Operatiion.addToHead(3);
            Operatiion.addToHead(4);
            Operatiion.addToHead(5);

            Operatiion.show();

            for(int i = 0; i < args.Length; i++) {
                Console.WriteLine(args[i]);
            }
        }
    }
}
