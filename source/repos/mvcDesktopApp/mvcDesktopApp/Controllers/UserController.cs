using Microsoft.AspNetCore.Mvc;
using mvcDesktopApp.Models;

namespace mvcDesktopApp.Controllers
{
    public class UserController : Controller
    {
            [HttpGet]

            public IActionResult UserList()
            {
                User user = new User(10001, "abcd", "abc@gmail.com");
                return View(user);
            }
        public IActionResult StudentList()
        {
            Student student = new Student( "Irfan Alam", "Kathmandu");
            return View(student);
        }
        public IActionResult Login()
            {
                return View();
            }
        [HttpGet]
            public IActionResult DoLogin()
            {
                //login logic
                return View();
            }
            public IActionResult Register()
            {
                //signup logic
                return View();
            }
            public IActionResult ForgotPassword()
            {

                return View();
            }
            public IActionResult ChangePassword()
            {

                return View();
            }

        
    }
}
