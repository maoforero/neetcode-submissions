  using System;
  public class Cockroach
  {
    public static int CockroachSpeed(double x)
    {
      //#Happy Coding! ^_^
      double convertionFactor = 0.036;
      double operation        = x / convertionFactor;
      int speedCmSecond       = (int)operation;
      
      return speedCmSecond; 
    }
  }

using NUnit.Framework;
using System;

[TestFixture]
public class CockTest1
{
    [Test]
    public void Test1()
    {
        Assert.That(Cockroach.CockroachSpeed(1.08), Is.EqualTo(30));
        Assert.That(Cockroach.CockroachSpeed(1.09), Is.EqualTo(30));
        Assert.That(Cockroach.CockroachSpeed(0), Is.EqualTo(0));
    }
}
