using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void SetWord_True()
    {
      //arrange
      string testword = "iLoveTests";
      Scrabble newScrabble = new Scrabble();

      //act
      newScrabble.SetWord(testword);
      string result = newScrabble.GetWord();

      //assert
      Assert.AreEqual(testword, result);
    }
    [TestMethod]
    public void ScoreFind_True()
    {
      //arrange
      char newLetter = 'D';

      //act
      Scrabble.ScoreFind(newLetter);
      int result = Scrabble.score;

      //assert
      Assert.AreEqual(2, result);
    }
  }
}
