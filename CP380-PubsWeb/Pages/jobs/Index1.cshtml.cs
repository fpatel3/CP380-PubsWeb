using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CP380_PubsWeb.CP380_PubsWeb.Pages
{
    public class Index1Model : PageModel
    {
       
            private readonly Models.PubsDbContext _db = new Models.PubsDbContext();

            [BindProperty]
            public List<Models.Jobs> JobsList { get; set; }
            public async Task<IActionResult> OnGet()
            {
                JobsList = await _db.Jobs.ToListAsync();
                return Page();
            }
       
    }
}
