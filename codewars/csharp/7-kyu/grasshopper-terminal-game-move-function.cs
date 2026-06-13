using System;

public class Game
{
  public static int Move(int position, int roll)
    => (roll * 2) + position;
}
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  public void Test1()
  {
    Assert.That(Game.Move(0,4), Is.EqualTo(8));
  }
}