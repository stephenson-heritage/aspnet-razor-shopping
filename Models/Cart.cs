using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_razor_shopping.Models;

public class Cart
{
	public uint CartId { get; set; }

	public virtual Product? Product { get; set; }

	public virtual Customer? Customer { get; set; }
	public uint Quantity { get; set; } = 0;


}