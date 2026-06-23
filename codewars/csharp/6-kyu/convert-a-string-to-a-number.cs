using System;
  public class Kata
  {
    public static int StringToNumber(String str) => int.Parse(str);
}
using NUnit.Framework;
using System;
[TestFixture]
public class StringToNumberTest
{ 
  [Test, Order(1)]
  public void test1()
  {
    Assert.That(Kata.StringToNumber("1234"), Is.EqualTo(1234));
  }

  [Test, Order(2)]
  public void test2()
  {
    Assert.That(Kata.StringToNumber("605"), Is.EqualTo(605));
  }

  [Test, Order(3)]
  public void test3()
  {
    Assert.That(Kata.StringToNumber("1405"), Is.EqualTo(1405));
  }

  [Test, Order(4)]
  public void test4()
  {