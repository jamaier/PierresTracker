using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test", "Test", "Test", "Test");
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

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_CategoryList()
    {
      string OrderTitle1 = "Title1";
      string OrderTitle2 = "Title2";
      Order newOrder1 = new Order(OrderTitle1, "Test", "Test", "Test");
      Order newOrder2 = new Order(OrderTitle2, "Test", "Test", "Test");
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();
      // Understanding now this needs IDispose ClearAll() method
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}