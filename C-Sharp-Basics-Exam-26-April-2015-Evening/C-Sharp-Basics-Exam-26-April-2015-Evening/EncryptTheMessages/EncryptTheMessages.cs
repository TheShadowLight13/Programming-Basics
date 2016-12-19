using System;
using System.Collections.Generic;

class EncryptTheMessages
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<string> encryptedMessages = new List<string>();
        string currentMessage = "";

        while (input.ToLower() != "start")
        {
            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input.ToLower() != "end")
        {
            if (input != "")
            {
                currentMessage = EncryptTheMessage(input);
                encryptedMessages.Add(currentMessage);
            }
            
            input = Console.ReadLine();
        }

        if (encryptedMessages.Count > 0)
        {
            Console.WriteLine("Total number of messages: {0}", encryptedMessages.Count);

            foreach (string message in encryptedMessages)
            {
                Console.WriteLine(message);
            }
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
    }

    private static string EncryptTheMessage(string input)
    {
        string currentMessage = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if ((input[i] >= 'a' && input[i] <= 'm') || (input[i] >= 'A' && input[i] <= 'M'))
            {
                currentMessage += (char)(input[i] + 13);
            }
            else if ((input[i] >= 'n' && input[i] <= 'z') || (input[i] >= 'N' && input[i] <= 'Z'))
            {
                currentMessage += (char)(input[i] - 13);
            }
            else if (input[i] >= '0' && input[i] <= '9')
            {
                currentMessage += input[i];
            }
            else
            {
                switch (input[i])
                {
                    case ' ': currentMessage += "+"; break;
                    case ',': currentMessage += "%"; break;
                    case '.': currentMessage += "&"; break;
                    case '?': currentMessage += "#"; break;
                    case '!': currentMessage += "$"; break;
                }
            }
        }

        return currentMessage;
    }
}

