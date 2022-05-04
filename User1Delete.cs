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
    public class User1Delete : Controller
    {
            private readonly TravelAgencyContext _context;

            public User1Delete(TravelAgencyContext context)
            {
                _context = context;
            }

            // GET: User1/Delete/5
            public async Task<IActionResult> Delete(int? id)
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

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var user1 = await _context.User1s.FindAsync(id);
                _context.User1s.Remove(user1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
    }
}

