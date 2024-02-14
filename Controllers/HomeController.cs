using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration; // New using directive.

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
  {
    private readonly string _apikey; // New property.

    // New Controller.
    public HomeController(IConfiguration configuration)
    {
      _apikey = configuration["NYT"];
    }

    public IActionResult Index()
    {
        List<Article> allArticles = Article.GetArticles(_apikey); // Using _apikey here!
        return View(allArticles);
    }
  }
}