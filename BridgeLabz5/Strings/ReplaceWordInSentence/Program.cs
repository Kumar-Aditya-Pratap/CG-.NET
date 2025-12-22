using System;

class ReplaceWordInSentence
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
            if (words[i] == oldWord)
                words[i] = newWord;

        Console.WriteLine("Modified Sentence: " + string.Join(" ", words));
    }
}
