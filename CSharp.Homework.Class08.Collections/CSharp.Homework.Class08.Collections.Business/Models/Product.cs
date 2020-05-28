using CSharp.Homework.Class08.Collections.Business.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class08.Collections.Business.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }


        public Product()
        {

        }

        public Product(int id, string name, int price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
            Id = id;
        }

        public void ProductInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price}, Category: {Category}");
        }
    }
}
