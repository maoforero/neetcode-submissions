using System.Linq;

public class Kata
{
  public static int[] SortNumbers(int[] nums)
    => nums is null ? new int[0] : nums.OrderBy(x => x).ToArray();
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
      checkNums(new int[] { 1,2,3,10,5 }, new int[] { 1,2,3,5,10 });
      checkNums(null, new int[] { });
      checkNums(new int[] { }, new int[] {  });
      checkNums(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 });
      checkNums(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 });
      checkNums(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 });
    }
  
    private void checkNums(int[] nums, int[] expected)
    {
      var actual = Kata.SortNumbers(nums);
    
      Assert.That(actual, Is.EqualTo(expected), nums != null ? "{" + string.Join(",", nums) + "}" : "null");
    }
  }
}
