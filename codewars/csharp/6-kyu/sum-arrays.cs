public class Kata
{
  public static double SumArray(double[] array)
  {
    double result = 0;
    
    if(array.Length == 0)
      return result;
    
    foreach(double n in array){
      result += n;
    }
    
    return result;
  }
}
namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Sample_Test
  {
    private static object[] testCases = new object[]
    {
      new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
      new object[] {new double[] {}, 0},
    };
  
    [Test, TestCaseSource("testCases")]
    public void Test(double[] array, double expected) => Assert.That(Kata.SumArray(array), Is.EqualTo(expected));
  }
}