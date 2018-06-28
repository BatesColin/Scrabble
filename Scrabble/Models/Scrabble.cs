using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Scrabble
  {
    private string _inputWord;
    public static int score = 0;
    public static Dictionary<string, int> pointsDictionary = new Dictionary<string, int>()
    {
      {"A", 1},
      {"B", 3},
      {"C", 3},
      {"D", 2},
      {"E", 1},
      {"F", 4},
      {"G", 2},
      {"H", 4},
      {"I", 1},
      {"J", 8},
      {"K", 5},
      {"L", 1},
      {"M", 3},
      {"N", 1},
      {"O", 1},
      {"P", 3},
      {"Q", 10},
      {"R", 1},
      {"S", 1},
      {"T", 1},
      {"U", 1},
      {"V", 4},
      {"W", 4},
      {"X", 8},
      {"Y", 4},
      {"Z", 10}
    };
    public void SetWord(string inputWord)
    {
      _inputWord = inputWord;
    }
    public string GetWord()
    {
      return _inputWord;
    }
    public static void ScoreFind(char letter)
    {
      score += pointsDictionary[letter.ToString().ToUpper()];
    }
    public void TestWord()
    {
      // string testWord = newScrabble.GetWord();
      foreach (char letter in _inputWord)
      {
        Scrabble.ScoreFind(letter);
      }
    }
  }
  public class Program
  {
    public static void Main()
    {
      Scrabble newScrabble = new Scrabble();
      Console.WriteLine("Enter a word");
      string word = Console.ReadLine();
      newScrabble.SetWord(word);
      newScrabble.TestWord();
      Console.WriteLine("The word " + word + " has the score " + Scrabble.score + ".");
    }
  }
}
