using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using TFNetSecuriteDemo.Context;
using TFNetSecuriteDemo.Models;

namespace TFNetSecuriteDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDB.Users);
        }

        public IActionResult Details(int id)
        {
            User? user = FakeDB.Users.FirstOrDefault(u => u.Id == id);
            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            User? user = FakeDB.Users.FirstOrDefault(u => u.Id == id);
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            
            return View();
        }
    }
}
