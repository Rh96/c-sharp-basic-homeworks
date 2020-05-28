using CSharp.Homework.Class08.Collections.Business.Database;
using CSharp.Homework.Class08.Collections.Business.Enum;
using System;

namespace CSharp.Homework.Class08.Collections.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();

            //var searchProductByCategory = productRepository.SearchProductsByCategory(Category.LapTop);

            //var filterProductByPriceRange = productRepository.FilterProductsByPriceRange(0, 1000);

            //var searchProductByPartName = productRepository.SearchProductByPartName("a");

            //var getProductsByIds = productRepository.GetProductsByIds(5);

            //var getProductByPrice = productRepository.GetProductsByPrice(10);

            //var getCheapestProduct = productRepository.GetCheapestProduct();

            //var getExpensiveProduct = productRepository.GetExpensiveProduct();

            //var createProduct = productRepository.CreateProduct(22, "Kayak", 500, Category.ItEquipment);

            var removeProduct = productRepository.RemoveProduct(21);

            

            Console.ReadLine();
        }
    }
}
