#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspnet_razor_shopping.Models;

namespace aspnet_razor_shopping.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly aspnet_razor_shopping.Models.ShoppingDbContext _context;

        public IndexModel(aspnet_razor_shopping.Models.ShoppingDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
