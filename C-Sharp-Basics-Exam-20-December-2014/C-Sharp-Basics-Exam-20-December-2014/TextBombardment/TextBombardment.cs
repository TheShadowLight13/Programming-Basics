using System;
using System.Linq;
using System.Collections.Generic;

class TextBombardment
{
    static void Main()
    {
        string text = Console.ReadLine();
        int lineWidth = int.Parse(Console.ReadLine());
        List<int> colsToBeBombed = new List<int>(Console.ReadLine().
            Split().Select(int.Parse).ToList());
       
        int startIndex = 0;
        int rows = text.Length / lineWidth;
        
        if ((text.Length % lineWidth) > 0)
        {
            rows++;
        }
        List<string> wordsPerRow = new List<string>();

        for (int i = 0; i < rows; i++)
        {
            if ((text.Length - startIndex) < lineWidth)
            {
                wordsPerRow.Add(text.Substring(startIndex, text.Length - startIndex));
            }
            else
            {
                wordsPerRow.Add(text.Substring(startIndex, lineWidth));
                startIndex += lineWidth;
            }  
        }

        string lastRowText = wordsPerRow[rows - 1];
        
        for (int row = 0; row < rows; row++)
        {           
            string textInRow = wordsPerRow[row];
            
            for (int col = 0; col < lineWidth; col++)
            {
                if ((row == rows - 1) && (col >= lastRowText.Length))
                {
                    break;
                }

                if (row >= 2 && colsToBeBombed.Contains(col))
                {
                    string firstPreviousTextInRow = wordsPerRow[row - 2];
                    string secondPreviousTextInRow = wordsPerRow[row - 1];

                    if (firstPreviousTextInRow[col] != ' ' && secondPreviousTextInRow[col] == ' ')
                    {
                        colsToBeBombed.Remove(col);
                        Console.Write(textInRow[col]);
                        continue;
                    }       
                }
                
                if (!colsToBeBombed.Contains(col))
                {
                    Console.Write(textInRow[col]);
                }
                else
                {
                    Console.Write(' ');
                }
            }
        }
    }
}

