using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Tire
    {
        public Tire( double presure,int age)
        {
            Age = age;
            Presure = presure;
        }

        public int Age { get; set; }
        public double Presure { get; set; }

    }

}
