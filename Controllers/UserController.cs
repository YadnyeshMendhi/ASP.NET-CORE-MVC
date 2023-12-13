using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreMVC.Models;

namespace ASPNetCoreMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> UserDetails()
        {
              return View(await _context.Users.ToListAsync());
        }

      

        // GET: User/AddOrEditUser
        public IActionResult AddOrEditUser(int id = 0)
        {
            if (id == 0)
				return View(new User());
			else
                return View(_context.Users.Find(id));
        }

        // POST: User/AddOrEditUser
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditUser([Bind("ID,FirstName,LastName,ContactNumber,City,State,Date")] User user)
        {
            if (ModelState.IsValid)
            {
                if (user.ID == 0)
                {
                    user.Date = DateTime.Now;
                    _context.Add(user);
                }
                else
                    _context.Update(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserDetails));
                
            }
            return View(user);
        }

    
        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'userDbContext.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserDetails));
        }

      /*  private bool TransactionExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionID == id);
        }*/
    }
}