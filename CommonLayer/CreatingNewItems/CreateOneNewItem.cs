using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewItems
{
    class CreateOneNewItem
    {
        // Properties
        public Item Item { get; set; }
        public string ItemName { get; set; }
        public int ShelfFloorNumber { get; set; }
        public string FoodOrDrink { get; set; }
        public string FoodType { get; set; }
        public DateTime LastDay { get; set; }
        public double Capacity { get; set; }

        public List<string> possibleFoodOrDrink { get; set; }
        public List<string> FoodTypes { get; set; }
        private int Day;
        private int Month;
        private int Year;

        // Constructror
        //CR: Functions in the class not need to be in the ctor
        //CR: Split it to diffrent class with his functions
        public CreateOneNewItem()
        {
            PossibleFoodOrDrinkInputs FoodOrDrinkInputs = new PossibleFoodOrDrinkInputs();
            PossibleFoodTypeInputs FoodTypeInputs = new PossibleFoodTypeInputs();

            this.possibleFoodOrDrink = FoodOrDrinkInputs.possibleInputs;
            this.FoodTypes = FoodTypeInputs.possibleInputs;

            this.Item = this.InputNewItem();
        }

        // Methods
        //CR: Don't implement the algorithem
        //CR: SRP
        public bool FoodOrDrinkVerify()
        {
            if (this.possibleFoodOrDrink != null)
            {
                foreach (string s in this.possibleFoodOrDrink)
                {
                    if (this.FoodOrDrink.Equals(s))
                        return (true);
                }
            }

            return (false);
        }

        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        public void GetOnlyFoodOrDrink()
        {
            while (!this.FoodOrDrinkVerify())
            {
                Console.WriteLine("Wrong. Enter only 'Food' or 'Drink' Inputs.");
                this.FoodOrDrink = Console.ReadLine();
            }
        }

        //CR: Don't implement the algorithem
        //CR: SRP
        public bool FoodTypeVerify()
        {
            if (this.FoodTypes != null)
            {
                foreach (string s in this.FoodTypes)
                {
                    if (this.FoodType.Equals(s))
                        return (true);
                }
            }

            return (false);
        }

        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        public void GetCorrectFoodType()
        {
            while (!this.FoodTypeVerify())
            {
                Console.WriteLine("Wrong Inputs.");
                this.FoodType = Console.ReadLine();
            }
        }

        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        public Item InputNewItem()
        {
             Console.WriteLine("Enter Item's Name:");
             this.ItemName = Console.ReadLine();

             Console.WriteLine("Enter Food Or Drink:");
             this.FoodOrDrink = Console.ReadLine(); 

             if (!this.FoodOrDrinkVerify())
                this.GetOnlyFoodOrDrink();

             Console.WriteLine("Enter Food Type:");
             this.FoodType = Console.ReadLine();

             if (this.FoodTypeVerify())
                 this.GetCorrectFoodType();

             Console.WriteLine("Enter Date by the following request:");
             Console.WriteLine("Enter day:");
             Day = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter month:");
             Month = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter year:");
             Year = int.Parse(Console.ReadLine());
             this.LastDay = new DateTime(Year, Month, Day);

             Console.WriteLine("Enter Capacity:");
             this.Capacity = int.Parse(Console.ReadLine());

             var item = new Item(this.ItemName, this.FoodOrDrink, this.FoodType, this.LastDay, this.Capacity);

             return item;
        }
    }
}
