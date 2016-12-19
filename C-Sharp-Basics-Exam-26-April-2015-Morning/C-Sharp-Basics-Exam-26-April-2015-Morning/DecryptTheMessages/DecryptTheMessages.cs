using System;
using System.Collections.Generic;
using System.Linq;

class DecryptTheMessages
{
    static void Main()
    {
        List<string> decryptedMessages = new List<string>();

        string currentStr = Console.ReadLine();

        while (true)
        {
            if (currentStr.ToLower() == "start")
            {
                currentStr = Console.ReadLine();
                break;
            }
            else
            {
                currentStr = Console.ReadLine();
            }
        }
        
        while (currentStr.ToLower() != "end")
        {
            if (currentStr != "")
            {
                string decryptedMessage = DecryptTheMessage(currentStr);
                decryptedMessages.Add(decryptedMessage);
            }
            currentStr = Console.ReadLine();
        }

        if (decryptedMessages.Count == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", decryptedMessages.Count);
            
            foreach (string message in decryptedMessages)
            {
                Console.WriteLine(message);
            }
        }
        
    }

    private static string DecryptTheMessage(string encryptedMessage)
    {
        string decryptedMessage = "";
   
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            if (encryptedMessage[i] >= 'A' && encryptedMessage[i] <= 'M')
            {
                decryptedMessage += (char)('N' + (encryptedMessage[i] - 'A'));
            }
            else if (encryptedMessage[i] >= 'N' && encryptedMessage[i] <= 'Z')
            {
                decryptedMessage += (char)('A' + (encryptedMessage[i] - 'N'));
            }
            else if (encryptedMessage[i] >= 'a' && encryptedMessage[i] <= 'm')
            {
                decryptedMessage += (char)('n' + (encryptedMessage[i] - 'a'));
            }
            else if (encryptedMessage[i] >= 'n' && encryptedMessage[i] <= 'z')
            {
                decryptedMessage += (char)('a' + (encryptedMessage[i] - 'n'));
            }
            else if (encryptedMessage[i] >= '0' && encryptedMessage[i] <= '9')
            {
                decryptedMessage += (char)(encryptedMessage[i]);
            }
            else
            {
                switch (encryptedMessage[i])
                {
                    case '+': decryptedMessage += ' '; break;
                    case '%': decryptedMessage += ','; break;
                    case '&': decryptedMessage += '.'; break;
                    case '#': decryptedMessage += '?'; break;
                    case '$': decryptedMessage += '!'; break;
                }
            }
        }
        char[] finalMessage = decryptedMessage.ToCharArray();
        Array.Reverse(finalMessage);
        decryptedMessage = new string(finalMessage);
        
        return decryptedMessage;
    }
}

