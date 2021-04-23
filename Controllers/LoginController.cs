using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealtorApp.Data;
using RealtorApp.Models;


namespace RealtorApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly PropertyContext _context;

        public LoginController(PropertyContext context)
        {
            _context = context;
        }

        // GET: Login/Delete/5
        public IActionResult LoginDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["id"] = id;
            return View();
        }

        // GET: Login/Login
        public IActionResult Login()
        {
            return View();
        }


        // GET: Login/Edit/5
        public IActionResult LoginEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["id"] = id;
            return View();
        }
    }
}
