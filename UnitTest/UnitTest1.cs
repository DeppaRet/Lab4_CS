﻿using System;
using Lab4_CS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string cmd = "SELECT* FROM Athlete";
      Work.openDatabase(cmd);
    }
    [TestMethod]
    public void TestMethod2()
    {
      Work.ChangeSport("9", "Скелетон", "Секунды", "248", "11 января 2016 г.");
    }
  }
}
