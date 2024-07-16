using System;

class Program
{
    static void Main()
    {
        string[] words = { "яблоко", "лампа", "лоза", "наушники", "книга", "картина", "зима", "вода", "голова", "карандаш", "солнце", "собака", "город", "зависимость", "папа", "узоры"};
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        string guessedWord = new string('_', wordToGuess.Length);

        Console.WriteLine("Угадайте слово:");
        Console.WriteLine(guessedWord);

        while (guessedWord != wordToGuess)
        {
            string guess = Console.ReadLine().ToLower();

            if (guess == wordToGuess)
            {
                Console.WriteLine("Поздравляем, вы угадали слово!");
                break;
            }
            else
            {
                Console.WriteLine("Попробуйте еще раз:");
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (i < guess.Length && guess[i] == wordToGuess[i])
                    {
                        Console.Write(wordToGuess[i]);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}