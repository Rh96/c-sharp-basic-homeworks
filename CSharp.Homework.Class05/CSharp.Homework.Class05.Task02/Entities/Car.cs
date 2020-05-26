using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class05.Task02.Entities
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }
    }
}
