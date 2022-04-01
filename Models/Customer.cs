using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_razor_shopping.Models;

public class Customer
{
	public uint CustomerId { get; set; }

	public string Name { get; set; } = "Customer Name";

	public virtual IList<Cart>? CartItems { get; set; }


}