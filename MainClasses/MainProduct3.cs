using System;
using System.Collections.Generic;
using Depth.Products;
namespace Depth.MainClasses
{
    public class MainProduct3
    {
		public static void MyMain()
		{
			List<Product3> products = Product3.GetSampleProducts();
            products.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));
			foreach (Product3 product in products)
			{
				Console.WriteLine(product);
			}
		}
    }
}
