using System;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
      int len       = s.Length;
      double result = 0;
      
      for(int i = 0; i <= len - 1; i++){
        var nu  = (int)char.GetNumericValue(s[i]);
        var exp = (len - 1) - i;
        var op  = Math.Pow(2, exp);
        
        result  += nu * op;
      }
      
      return (int)result;
    }
  }
}
namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void MyTest()
    {
      Assert.That(Program.binToDec("0"), Is.EqualTo(0));
      Assert.That(Program.binToDec("1"), Is.EqualTo(1));
      Assert.That(Program.binToDec("10"), Is.EqualTo(2));
      Assert.That(Program.binToDec("11"), Is.EqualTo(3));
      Assert.That(Program.binToDec("110"), Is.EqualTo(6));
    }
  }
}
