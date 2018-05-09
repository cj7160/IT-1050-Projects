using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Final
{
    class Passenger
    {
        private string Name;
        private double Weight;
        public static double TotalWeight;

        
        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

            Passenger.TotalWeight += this.Weight;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }

       
    }
}
