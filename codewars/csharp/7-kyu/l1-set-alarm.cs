public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;
}
namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SetAlarmTest {
    [Test]
    public void Tests() {
      Assert.That(Kata.SetAlarm(true, true), Is.False);
      Assert.That(Kata.SetAlarm(false, true), Is.False);
      Assert.That(Kata.SetAlarm(true, false), Is.True);
      Assert.That(Kata.SetAlarm(false, false), Is.False);
    }
  }
}