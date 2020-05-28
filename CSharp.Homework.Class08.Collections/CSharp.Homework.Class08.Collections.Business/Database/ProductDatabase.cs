using CSharp.Homework.Class08.Collections.Business.Enum;
using CSharp.Homework.Class08.Collections.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class08.Collections.Business.Database
{
    public class ProductDatabase:Product
    {
        public List<Product> Products = new List<Product>
        {
            new Product() { Id = 1, Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
            new Product() { Id = 2, Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
            new Product() { Id = 3, Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
            new Product() { Id = 4, Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
            new Product() { Id = 5, Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
            new Product() { Id = 6, Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
            new Product() { Id = 7, Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
            new Product() { Id = 8, Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
            new Product() { Id = 9, Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
            new Product() { Id = 10, Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
            new Product() { Id = 11, Name =  "Office 1", Price = 10200, Category = Category.PC},
            new Product() { Id = 12, Name =  "Office 2", Price = 12400, Category = Category.PC},
            new Product() { Id = 13, Name =  "Gaming", Price = 22000, Category = Category.PC},
            new Product() { Id = 14, Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
            new Product() { Id = 15, Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
            new Product() { Id = 16, Name =  "Alienware", Price = 128000, Category = Category.PC},
            new Product() { Id = 17, Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
            new Product() { Id = 18, Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
            new Product() { Id = 19, Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
            new Product() { Id = 20, Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
            new Product() { Id = 21, Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
        };
    }
}
