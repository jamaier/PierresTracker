using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorName_ChecksNameOfVendor_Vendor()
    {
      string vendorName = "Vendors Name";
      Vendor newVendor = new Vendor(vendorName);
      Assert.AreEqual(vendorName, newVendor.Name);
    }
  }
}