#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Old_Glory.Data;
using Old_Glory.Models;

namespace Old_Glory.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Old_Glory.Data.Old_GloryContext _context;

        public IndexModel(Old_Glory.Data.Old_GloryContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
