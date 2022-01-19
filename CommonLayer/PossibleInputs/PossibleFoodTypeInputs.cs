using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.DAL
{
    //CR: Not in the common layer
    class PossibleFoodTypeInputs
    {
        // Properties
        public List<string> possibleInputs { get; set; }

        // Constructor
        public PossibleFoodTypeInputs()
        {
            this.possibleInputs = new List<string>();
            this.possibleInputs.Add("Parve");
            this.possibleInputs.Add("Milky");
            this.possibleInputs.Add("Meety");
        }
    }
}
