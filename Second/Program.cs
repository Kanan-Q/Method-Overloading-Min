namespace Second;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        string sentence = "proqramlaşdırma dili";
        string firstLetters = FirstLetters(sentence);
        WriteLine("Sozlerin bas herfleri: " + firstLetters);
    }

    static string FirstLetters(string sentence)
    {
        string result = "";
        bool Word = true;

        for (int i = 0; i < sentence.Length; i++)
        {

            if (Word && sentence[i] != ' ')
            {
                result += sentence[i];
                Word = false;
                break;
            }
            else if (sentence[i] == ' ')
            {
                Word = true;
            }
        }

        return result;
    }
}
