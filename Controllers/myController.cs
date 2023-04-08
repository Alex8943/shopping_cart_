using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace shopping_cart_.Controllers;

public class shoppingCartController : Controller
{
    // 
    // GET: /myController/
   public IActionResult Index()
    {
        return View();
    }

   // GET: /myController/Welcome/ 
   // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}