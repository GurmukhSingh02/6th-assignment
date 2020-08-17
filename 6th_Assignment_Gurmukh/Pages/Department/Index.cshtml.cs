using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _6th_Assignment_Gurmukh.Biz;
using _6th_Assignment_Gurmukh.Data;

namespace _6th_Assignment_Gurmukh.Pages.Department
{
    public class IndexModel : PageModel
    {
        private readonly _6th_Assignment_Gurmukh.Data.ApplicationDbContext _context;

        public IndexModel(_6th_Assignment_Gurmukh.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Biz.Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Departments.ToListAsync();
        }
    }
}
