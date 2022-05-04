#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelAgency1.Models;

namespace TravelAgency1.Controllers
{
    public class User1Post : Controller
    {
        private readonly TravelAgencyContext _context;

        public User1Post(TravelAgencyContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Firstname,Lastname,Age,Country,Address,Email,Password")] User1 user1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user1);
        }
    }
}
