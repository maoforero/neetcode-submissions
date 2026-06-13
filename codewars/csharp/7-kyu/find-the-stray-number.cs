class Solution 
{
  public static int Stray(int[] numbers)
  {
    for(int i = 0; i < numbers.Length; i++){
      int first = numbers[i];
      int midd  = numbers[i+1];
      int limit = numbers[i+2];
      
      if(first != midd && midd != limit)
        return midd;
      
      if(first == midd && midd != limit)
        return limit;
      
      if(first != midd && midd == limit)
        return first;
    }
    
    return 0;
  }
}
using NUnit.Framework;

[TestFixture]
public class SolutionTest
{
  [Test]
  public void SimpleArray1()
  {
    Assert.That(Solution.Stray(new int[] {1, 1, 2}), Is.EqualTo(2));
  }
}
