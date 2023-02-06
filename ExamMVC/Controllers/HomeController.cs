﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExamMVC.Models;

namespace ExamMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        Response.Redirect("/Topics/index");
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        //Console.WriteLine("In Get Method of Account Login");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
