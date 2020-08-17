using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _6th_Assignment_Gurmukh.Biz;
using _6th_Assignment_Gurmukh.Data;

namespace _6th_Assignment_Gurmukh.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly _6th_Assignment_Gurmukh.Data.ApplicationDbContext _context;

        public DetailsModel(_6th_Assignment_Gurmukh.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Biz.Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Job).FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
