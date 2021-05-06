using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello , please enter the key ");
            int[] keyNumber = new int[10];
            for (int i = 0; i < keyNumber.Length; i++)
            {
                keyNumber[i] = Convert.ToInt32(Console.In.ReadLine());

            }

            Console.WriteLine(" please enter the mass ");
            int[] message = new int[14];

            for (int x = 0; x < message.Length; x++)
            {
                message[x] = Convert.ToInt32(Console.In.ReadLine());
            }

            int[] encryptedMessage = new int[message.Length];
            Console.WriteLine("the key ");

            for (int y = 0; y < encryptedMessage.Length; y++)
            {
                encryptedMessage[y] = keyNumber[message[y]];
                if (encryptedMessage[y] == 8){ encryptedMessage[y]=2;}
                if (encryptedMessage[y] == 0){ encryptedMessage[y]=8;}
                Console.Write(encryptedMessage[y]);
            }

        }
    }
}
