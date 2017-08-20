using System;
using System.Collections.Generic;
namespace Depth.Products
{
	public class Product2
	{
		string name;
		public string Name
		{
			get { return name; }
			private set { name = value; }
		}

		decimal price;
		public decimal Price
		{
			get { return price; }
			private set { price = value; }
		}

		public Product2(string name, decimal price)
		{
			this.name = name;
			this.price = price;
		}

		public static List<Product2> GetSampleProducts()
		{
			List<Product2> list = new List<Product2>();
			list.Add(new Product2("V", 4.99m));
			list.Add(new Product2("Viva la vida", 5m));
			list.Add(new Product2("A Thousand Suns", 9.98m));
			list.Add(new Product2("Dreaming out loud", 8.99m));
			return list;
		}

		public override string ToString()
		{
			return string.Format("[Product2: Name={0}, Price={1}]", name, price);
		}
	}
}
