﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace myMath.Tests
{
    public partial class HelpersTest
    {

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption873()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(2, "close", (object)true);
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87301()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87302()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87303()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "\0");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87304()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "0");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87305()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", ":");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87306()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "00");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87307()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87308()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-\0");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void GetOption87309()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-000");
      i = this.GetOption((string)null);
      PexAssert.AreEqual<int>(0, i);
    }
}
    }
}
