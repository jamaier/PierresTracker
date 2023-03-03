using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}