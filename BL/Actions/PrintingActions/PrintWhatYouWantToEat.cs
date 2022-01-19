using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintWhatYouWantToEat
    {
        // Properties
        private Fridge Fridge;
        private List<string> possibleFoodTypes;
        private List<string> possibleFoodOrDrinkInputs;


        // Constructor
        public PrintWhatYouWantToEat(Fridge Fridge)
        {
            this.Fridge = Fridge;

            PossibleFoodOrDrinkInputs FoodOrDrinkInputs = new PossibleFoodOrDrinkInputs();
            PossibleFoodTypeInputs FoodTypeInputs = new PossibleFoodTypeInputs();

            this.possibleFoodTypes = FoodOrDrinkInputs.possibleInputs;
            this.possibleFoodOrDrinkInputs = FoodTypeInputs.possibleInputs;

            Console.WriteLine("What Do You Want To Eat?\nFood Or Drink?");
            string FoodOrDrink = Console.ReadLine();
            Console.WriteLine("Food Type?");
            string FoodType = Console.ReadLine();

            if (this.ValidateFoodOrDrinkInput(FoodOrDrink) && this.ValidateFoodTypeInput(FoodType))
            {
                WhatDoYouWantToEat wannaEat = new WhatDoYouWantToEat(this.Fridge, FoodOrDrink, FoodType);
                wannaEat.FinalList();
            }
            else
                Console.WriteLine("Inputs Are Wrong. One Of Them Doesn't Exist In The System.");
        }

        // Methods
        public bool ValidateFoodTypeInput(string FoodType)
        {
            if (this.possibleFoodTypes != null)
            {
                foreach (string s in this.possibleFoodTypes)
                    if (s.Equals(FoodType))
                        return true;
            }
            else
                Console.WriteLine("Possible Food Types List Is Null.");

            return false;
        }

        public bool ValidateFoodOrDrinkInput(string FoodOrDrink)
        {
             if (this.possibleFoodOrDrinkInputs != null)
             {
                foreach (string s in this.possibleFoodOrDrinkInputs)
                    if (s.Equals(FoodOrDrink))
                        return true;
             }
             else
                Console.WriteLine("Possible Food Or Drink Inputs List Is Null.");
            
            return false;
        }
    }
}
