using System;
using System.Linq;
using System.Collections.Generic;

public class TwoToOne 
{
  
  public static string Longest (string s1, string s2) 
  {
    if (s1 == null && s2 == null)
        return string.Empty;

    var as1 = s1.ToArray();
    var as2 = s2.ToArray();
    var len = as1.Length > as2.Length ? as1.Length : as2.Length; 

    Array.Sort(as1);
    Array.Sort(as2);

    HashSet<char> list = new HashSet<char>();

    for (int i = 0; i < as1.Length; i++)
    {
        var ob1 = as1[i];
      
      for(int j = 0; j < as2.Length; j++){
        
        if(i > j)
          break;
        
        var ob2 = as2[j];
        
        if (!list.Contains(ob2))
          list.Add(ob2);
      }
        if (!list.Contains(ob1))
            list.Add(ob1);
    }

    var listResult = list.ToArray();
    Array.Sort(listResult);
    var result = string.Join("", listResult);  

    return result;
    
  }
}
using System;
using NUnit.Framework;

[TestFixture]
public static class TwoToOneTests 
{

    [Test]
    public static void test1() 
    {
        Assert.That(TwoToOne.Longest("aretheyhere", "yestheyarehere"), Is.EqualTo("aehrsty"));
        Assert.That(TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"), Is.EqualTo("abcdefghilnoprstu"));
        Assert.That(TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"), Is.EqualTo("acefghilmnoprstuy"));
    }    
}
