using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp
{
    public class Region
    {
        public required string Name { get; set; }
        public int MinBudget { get; set; }
        public int MaxBudget { get; set; }
        public required string Description { get; set; }
    }
}