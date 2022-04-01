using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_razor_shopping.Models;

public class Stock
{
	public uint StockId { get; set; }

	public uint Quantity { get; set; } = 0;

	public virtual Product? Product { get; set; }

}