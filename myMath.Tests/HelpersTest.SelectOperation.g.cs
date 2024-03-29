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
public void SelectOperation108()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(2, "close", (object)(PexSafeHelpers.ByteToBoolean((byte)2)));
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10801()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10802()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10803()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "\0");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10804()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "0");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10805()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", ":");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10806()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10807()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "00");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10808()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-0");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(HelpersTest))]
public void SelectOperation10809()
{
    using (PexPConsoleInContext.Create())
    {
      int i;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "000");
      i = this.SelectOperation();
      PexAssert.AreEqual<int>(0, i);
    }
}
    }
}
