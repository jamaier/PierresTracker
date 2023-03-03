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
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorName_ChecksNameOfVendor_Vendor()
    {
      string vendorName = "Vendors Name";
      Vendor newVendor = new Vendor(vendorName, "Vendor Description");
      Assert.AreEqual(vendorName, newVendor.Name);
    }

    [TestMethod]
    public void VendorDescription_ChecksDexcriptionOfVendor_Vendor()
    {
      string vendorDescription = "Describe vendor";
      Vendor newVendor = new Vendor("Vendors Name", vendorDescription);
      Assert.AreEqual(vendorDescription, newVendor.Description);
    }
  }
}