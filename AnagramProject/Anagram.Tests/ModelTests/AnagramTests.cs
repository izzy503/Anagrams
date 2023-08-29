using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramProject.Models;
using System.Collections.Generic;
using System;

namespace Anagram.TestTools
{
  [TestClass]
  public class AnagramTests : IDisposable
  {
    public void Dispose()
    {
      //Anagram.Method() goes here
    }
  }
  [TestMethod]
  public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
  {
    Anagram newAnagram = new Anagram("bath");

  }
}

[TestMethod]
public void IsAnagram_forNonAnagramWords_ReturnsTrue()
{
  Assert.IsTrue(Anagram.IsAnagram("Bath" , "Math"));
}

[TestMethod]
public void IsAnagram_forNonAnagramWords_ReturnsFalse()
{
  Assert.IsFalse(AnagramChecker.IsAnagram("Bath" , "Math"))
}