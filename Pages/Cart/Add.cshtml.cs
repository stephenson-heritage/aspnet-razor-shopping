#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_razor_shopping.Models;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace aspnet_razor_shopping.Pages_Cart
{
	public class AddModel : PageModel
	{
		private readonly aspnet_razor_shopping.Models.ShoppingDbContext _context;

		public AddModel(aspnet_razor_shopping.Models.ShoppingDbContext context)
		{
			_context = context;
		}


		public async Task<IActionResult> OnGetAsync(uint? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
			var customer = await _context.Customers.Where(c => c.CustomerId == 1).FirstOrDefaultAsync();

			_context.Cart.Add(new Cart { Product = product, Customer = customer, Quantity = 1 });
			await _context.SaveChangesAsync();



			if (product == null)
			{
				return NotFound();
			}
			return Page();
		}

		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see https://aka.ms/RazorPagesCRUD.


	}
}
