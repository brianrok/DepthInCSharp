using System;
using System.Collections.Generic;
namespace Depth.Products
{
	public class Product3
	{
		public string Name { get; private set; }
		public decimal Price { get; private set; }

		public Product3() { }

		public Product3(string name, decimal price)
		{
			Name = name;
			Price = price;
		}

		public static List<Product3> GetSampleProducts()
		{
			return new List<Product3> {
				new Product3(name: "V", price:4.99m),
				new Product3(name: "Viva la vida", price: 5m),
				new Product3(name: "A Thousand Suns", price: 9.98m),
				new Product3(name: "Dreaming out loud", price: 8.99m)
			};
		}

		public override string ToString()
		{
			return string.Format("[Product3: Name={0}, Price={1}]", Name, Price);
		}
	}
}
