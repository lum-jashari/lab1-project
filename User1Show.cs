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
    public class User1Show
    {
        private readonly TravelAgencyContext _context;

        public User1Show(TravelAgencyContext context)
        {
            _context = context;
        }

        // GET: User1
        public async Task<IActionResult> Index()
        {
            return View(await _context.User1s.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user1 = await _context.User1s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user1 == null)
            {
                return NotFound();
            }

            return View(user1);
        }

        // GET: User1/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
