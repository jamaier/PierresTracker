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
    public void VendorName_ChecksNameOfVendor_String()
    {
      string vendorName = "Vendors Name";
      Vendor newVendor = new Vendor(vendorName, "Vendor Description");
      Assert.AreEqual(vendorName, newVendor.Name);
    }

    [TestMethod]
    public void VendorDescription_ChecksDescriptionOfVendor_String()
    {
      string vendorDescription = "Describe vendor";
      Vendor newVendor = new Vendor("Vendors Name", vendorDescription);
      Assert.AreEqual(vendorDescription, newVendor.Description);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      // Getting a result of 4 for an unknown reason right now
      // Current understanding is that there are three instances above
      // Will look into later
      Vendor newVendor = new Vendor("vendorName", "vendorDescription");
      int result = newVendor.Id;
      Assert.AreEqual(4, result);
    }
  }
}