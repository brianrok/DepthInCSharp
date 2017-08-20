using System;
using System.Collections.Generic;
namespace Depth.Products
{
    public class Product1
    {
		string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		decimal price;
		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		public Product1(string name, decimal price)
		{
			this.name = name;
			this.price = price;
		}

		/**
		 * This should not be supported in C#1
		 */
		public static List<Product1> GetSampleProducts()
		{
			List<Product1> list = new List<Product1>();
			list.Add(new Product1("V", 4.99m));
			list.Add(new Product1("Viva la vida", 5m));
			list.Add(new Product1("A Thousand Suns", 9.98m));
			list.Add(new Product1("Dreaming out loud", 8.99m));
			return list;
		}

		public override string ToString()
		{
			return string.Format("[Product1: Name={0}, Price={1}]", name, price);
		}
	}

	public class Product1NameComparer : IComparer<Product1>
	{
		public int Compare(Product1 x, Product1 y)
		{
			return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
		}
	}

}
