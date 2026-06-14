using System.Linq;
namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
      => input.Select(x => x * -1).ToArray();
  }
}
namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Test
  {
    [Test]
    public void BasicTests()
    {
      Assert.That(ArraysInversion.InvertValues(new int[] {1,2,3,4,5}), Is.EqualTo(new int[] {-1,-2,-3,-4,-5}));
      Assert.That(ArraysInversion.InvertValues(new int []{1,-2,3,-4,5}), Is.EqualTo(new int[] {-1,2,-3,4,-5}));
      Assert.That(ArraysInversion.InvertValues(new int[] {}), Is.EqualTo(new int[] {}));
      Assert.That(ArraysInversion.InvertValues(new int[] {0}), Is.EqualTo(new int[] {0}));
    }
  }
}