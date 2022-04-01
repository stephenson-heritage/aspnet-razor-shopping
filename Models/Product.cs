using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_razor_shopping.Models;

public class Product
{
	public uint ProductId { get; set; }

	[MaxLength(128)]
	public string Name { get; set; } = "Product Name";

	public string? Description { get; set; }

	[DataType(DataType.Currency)]
	[Column(TypeName = "decimal(8,2)")]
	public decimal Price { get; set; } = 1;

}