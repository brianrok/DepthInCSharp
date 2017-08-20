using System;
using System.Collections.Generic;
namespace Depth.Products
{
	public class Product4
	{
		readonly string name;
		public string Name { get { return name; } }

		readonly decimal price;
		public decimal Price { get { return price; } }

		public Product4(string name, decimal price)
		{
			this.name = name;
			this.price = price;
		}

		public static List<Product4> GetSampleProducts()
		{
			return new List<Product4> {
				new Product4(name: "V", price:4.99m),
				new Product4(name: "Viva la vida", price: 5m),
				new Product4(name: "A Thousand Suns", price: 9.98m),
				new Product4(name: "Dreaming out loud", price: 8.99m)
			};
		}

		public override string ToString()
		{
			return string.Format("[Product4: Name={0}, Price={1}]", Name, Price);
		}
	}
}
