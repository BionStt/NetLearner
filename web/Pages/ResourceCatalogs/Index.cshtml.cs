﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetLearnerWeb.Models;
using web.Data;

namespace NetLearnerWeb.Pages.ResourceCatalogs
{
    public class IndexModel : PageModel
    {
        private readonly web.Data.ApplicationDbContext _context;

        public IndexModel(web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ResourceCatalog> ResourceCatalog { get;set; }

        public async Task OnGetAsync()
        {
            ResourceCatalog = await _context.ResourceCatalog.ToListAsync();
        }
    }
}
