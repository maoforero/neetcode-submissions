using System.Linq;

public class Kata
{
  public static string GetMiddle(string s)
    => s.Length % 2 == 0 ?
    s.Substring((s.Length - 1) / 2 , 2) :
    s.Substring(s.Length / 2, 1);
}
using NUnit.Framework;  
using System;
[TestFixture]
public class GetMiddleTest
{
  [Test, Order(1)]
  public void GenericTests()
  {
    Assert.That(Kata.GetMiddle("test"), Is.EqualTo("es"));
    Assert.That(Kata.GetMiddle("testing"), Is.EqualTo("t"));
    Assert.That(Kata.GetMiddle("middle"), Is.EqualTo("dd"));
    Assert.That(Kata.GetMiddle("A"), Is.EqualTo("A"));
  }
}