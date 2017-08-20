using System;
using System.Collections.Generic;
using Depth.Products;
namespace Depth.MainClasses
{
    public class MainProduct1
    {
		public static void MyMain()
		{
			List<Product1> products = Product1.GetSampleProducts();
			products.Sort(new Product1NameComparer());
			foreach (Product1 product in products)
			{
				System.Console.WriteLine(product);
			}
		}
    }
}
