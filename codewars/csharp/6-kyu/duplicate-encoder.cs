public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string result = string.Empty;
    
    for (int i = 0; i < word.Length; i++)
    {
    int match = 0;
    char pos = word.ToLower()[i];
    
    for (int j = 0; j < word.Length; j++)
    {
        char vali = word.ToLower()[j];
        if(vali == pos && j != i)
        {
            match++;
        }
    }

      if(match != 0)
      {
          result += ")";
      }
      else
      {
          result += "(";
      }
    }
    
    
    return result;
  }
}
namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.That(Kata.DuplicateEncode("din"), Is.EqualTo("((("));
      Assert.That(Kata.DuplicateEncode("recede"), Is.EqualTo("()()()"));
      Assert.That(Kata.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
      Assert.That(Kata.DuplicateEncode("(( @"), Is.EqualTo("))(("));
    }
  }
}
