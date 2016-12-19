using System;
using System.Text;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToLower();

        int symbolsSum = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] >= 'a' && message[i] <= 'z')
            {
                symbolsSum += (message[i] - 'a') + 1;
            }
            else
            {
                symbolsSum += message[i];
            }
        }
        StringBuilder decryptedMessage = new StringBuilder();

        while (symbolsSum > 0)
        {
            decryptedMessage.Insert(0, symbolsSum % key);
            symbolsSum /= key;
        }

        Console.Write(key);
        Console.Write(message.Length);
        Console.WriteLine(decryptedMessage);

    }
}

