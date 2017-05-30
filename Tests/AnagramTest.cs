using Xunit;
using System;
using System.Collections.Generic;
using AnagramProject.Objects;

namespace AnagramProjects
{
  public class AnagramTest
  {
    [Fact]
    public void IsString()
    {
      Anagram newAnagram = new Anagram();
      Assert.Equal("iceman", newAnagram.CheckAnagram("cinema", "iceman"));
    }
  }
}
