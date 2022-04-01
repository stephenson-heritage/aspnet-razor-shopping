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
    public class DetailsModel : PageModel
    {
        private readonly aspnet_razor_shopping.Models.ShoppingDbContext _context;

        public DetailsModel(aspnet_razor_shopping.Models.ShoppingDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
