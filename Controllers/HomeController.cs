using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cashier_POS.Models;
using Cashier_POS.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Cashier_POS.Controllers;

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

    public bool LoginAction(string username, string password)
    {
        using (CashierPosDBContext context = new CashierPosDBContext())
        {
            List<UserModel> users = context.Users.ToList();

            if (users.Where(u => u.UserName == username && u.Password == password).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
