﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UAOOI.Configuration.Networking.Serialization;

namespace UAOOI.Configuration.Networking.UnitTest
{
  [TestClass]
  public class UATypeInfoUnitTest
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CreatorADNullTestMethod1()
    {
      new UATypeInfo(BuiltInType.Byte, 0, null);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void CreatorADLengthTestMethod1()
    {
      new UATypeInfo(BuiltInType.Byte, 0, new int[] { });
    }
    [TestMethod]
    public void CreatorTestMethod1()
    {
      Assert.IsNotNull(new UATypeInfo(BuiltInType.Byte, 0, new int[] { 1, 2, 3 }));
    }
  }
}
