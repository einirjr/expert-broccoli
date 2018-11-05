﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dinwin.Data;
using dinwin.Models;

namespace dinwin.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly dinwin.Data.ApplicationDbContext _context;

        public IndexModel(dinwin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
