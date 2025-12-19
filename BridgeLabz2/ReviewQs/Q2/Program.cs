using System;

class Q2
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        string ReverseSentence = "";
        int wordstart = 0;
        string reverse = "";
        for (int i=0;i<=input.Length;i++) 
        {
            if (i == input.Length || input[i] == ' ')
            {
                reverse = "";
                
                for (int j=i-1;j>=wordstart;j--) {
                    reverse += input[j];
                }
                ReverseSentence += reverse;
                if (i < input.Length) ReverseSentence += " ";
                wordstart = i + 1;

            }
           
        }
        Console.WriteLine(ReverseSentence);
        Console.ReadLine();
    }
}