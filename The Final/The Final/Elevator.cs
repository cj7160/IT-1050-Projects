using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int Index)
        {
            Occupants[Index] = passenger;
        }

        public double GetCurrentWeight()
        {
            return Passenger.TotalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return Passenger.TotalWeight > this.MaxWeight;

        }

    }
}
