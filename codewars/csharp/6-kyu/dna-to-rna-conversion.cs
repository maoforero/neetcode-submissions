namespace Converter {
  public class Converter
  {
    public string dnaToRna(string dna) => dna.Replace('T','U');

  }
}
namespace Converter {
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class Test
  {
    [Test]
    public void test()
    {
      Converter converter = new Converter();
      Assert.That(converter.dnaToRna("TTTT"), Is.EqualTo("UUUU"));
    }
  }
}