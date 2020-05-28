using CSharp.Homework.Class08.Collections.Business.Enum;
using CSharp.Homework.Class08.Collections.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class08.Collections.Business.Database
{
    public class ProductRepository:ProductDatabase
    {
        public List<Product> SearchProductsByCategory(Category category)
        {
            foreach (var product in Products)
            {
                if (product.Category == category)
                {
                    product.ProductInfo();
                }
            }
            return Products;
        }

        public List<Product> FilterProductsByPriceRange(int min, int max)
        {
            foreach (var product in Products)
            {
                if (product.Price >= min && product.Price <= max)
                {
                    product.ProductInfo();
                }
            }

            return Products;
        }

        public List<Product> SearchProductByPartName(string partName)
        {
            foreach (var product in Products)
            {
                if (product.Name.Contains(partName))
                {
                    product.ProductInfo();
                }
            }

            return Products;
        }

        public List<Product> GetProductsByIds(int id)
        {
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine(product.Id);
                    product.ProductInfo();
                }
            }

            return Products;
        }

        public List<Product> GetProductsByPrice(int id)
        {
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine(product.Price);
                    product.ProductInfo();
                }
            }
            return Products;
        }

        public Product GetCheapestProduct()
        {
            Product cheapestProduct = Products[0];

            foreach (var product in Products)
            {
                if (cheapestProduct.Price > product.Price)
                {
                    cheapestProduct = product;
                    product.ProductInfo();
                }
            }

            return cheapestProduct;
        }

        public Product GetExpensiveProduct()
        {
            Product expensiveProduct = Products[19];

            foreach (var product in Products)
            {
                if (expensiveProduct.Price < product.Price)
                {
                    expensiveProduct = product;
                    product.ProductInfo();
                }
            }

            return expensiveProduct;
        }

        public Product CreateProduct(int id, string name, int price, Category category)
        {
            Product newProduct = new Product(id, name, price, category);
            Products.Add(newProduct);

            foreach (var product in Products)
            {
                product.ProductInfo();
            }

            return newProduct;
        }

        public Product RemoveProduct(int id)
        {
            Product removeProduct = Products[0];

            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    removeProduct = product;
                    product.ProductInfo();
                }
            }
            Products.Remove(removeProduct);

            return removeProduct;
        }
    }
}
