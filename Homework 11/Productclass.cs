using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{
    internal class Productclass
    {
        public Productclass(string Name)
        {
            this.Name = Name;
        }
        public Productclass(string Name, byte Price)
        {
            this.Name = Name;
            this.Price = Price;
        }


        public string Name;
        public int Price=10;
    }
}
