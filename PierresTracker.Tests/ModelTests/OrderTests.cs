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
    public void OrderProperties_ChecksOrderTitle_String()
    {
      string orderTitle = "Test Title";
      Order newOrder = new Order(orderTitle, "Test", "Test", "Test");
      Assert.AreEqual(orderTitle, newOrder.Title);
    }
    
    
    [TestMethod]
    public void OrderProperties_ChecksOrderDescription_String()
    {
      string orderDescription = "Test Description";
      Order newOrder = new Order("Test", orderDescription, "Test", "Test");
      Assert.AreEqual(orderDescription, newOrder.Description);
    }
    
    
    [TestMethod]
    public void OrderProperties_ChecksOrderPrice_String()
    {
      string orderPrice = "Test Price";
      Order newOrder = new Order("Test", "Test", orderPrice, "Test");
      Assert.AreEqual(orderPrice, newOrder.Price);
    }
    
    
    [TestMethod]
    public void OrderProperties_ChecksOrderDate_String()
    {
      string orderDate = "Test Date";
      Order newOrder = new Order("Test", "Test", "Test", orderDate);
      Assert.AreEqual(orderDate, newOrder.Date);
    }
  }
}