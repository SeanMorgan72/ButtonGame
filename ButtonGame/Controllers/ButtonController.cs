using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButtonGame.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ButtonGame.Controllers
{
    public class ButtonController : Controller
    {
        private readonly IUpdateButton update;
        public ButtonController(IUpdateButton update)
        {
            this.update = update;
        }
        public IActionResult Index()
        {
            update.GenerateBadButton();
            return View();
        }
        public IActionResult One()
        {
            update.Choice(1);
            return RedirectToAction("Index");
        }
        public IActionResult Two()
        {
            update.Choice(2);
            return RedirectToAction("Index");
        }
        public IActionResult Three()
        {
            update.Choice(3);
            return RedirectToAction("Index");
        }

    }
}
