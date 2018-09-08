using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Pages.MyWorkExperience
{
    public class DeleteModel : PageModel
    {
        private readonly MyHomeWebsite.Data.MyWebsiteDbContext _context;

        public DeleteModel(MyHomeWebsite.Data.MyWebsiteDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WorkExperience WorkExperience { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WorkExperience = await _context.workExperiences.SingleOrDefaultAsync(m => m.ID == id);

            if (WorkExperience == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WorkExperience = await _context.workExperiences.FindAsync(id);

            if (WorkExperience != null)
            {
                _context.workExperiences.Remove(WorkExperience);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
