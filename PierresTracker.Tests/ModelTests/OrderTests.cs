using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test","Test","Test","Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    
    [TestMethod]
    public void OrderProperties_ChecksOrderProperties_String()
    {
      string orderTitle = "Test Title";
      Order newOrder = new Order(orderTitle, "Test", "Test", "Test");
      Assert.AreEqual(orderTitle, newOrder.Title);
    }
  }
}