using System;
using System.Collections.Generic;
using Depth.Products;
namespace Depth.MainClasses
{
    public class MainProduct2
    {
		public static void MyMain()
		{
			List<Product2> products = Product2.GetSampleProducts();
            products.Sort(delegate (Product2 x, Product2 y){
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            });
            foreach(Product2 product in products) {
                Console.WriteLine(product);
            }
		}
    }
}
