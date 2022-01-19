using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class Item
    {
        // Properties
        public string ItemName { get; set; }
        public int ShelfFloorNumber { get; set; }
        public string FoodOrDrink { get; set; }
        public string FoodType { get; set; }
        public DateTime LastDay { get; set; }
        public double Capacity { get; set; }

        // Constructor
        //CR: Variables in lowercase
        public Item(string ItemName, string FoodOrDrink, string FoodType, DateTime LastDay, double Capacity)
        {
            this.ItemName = ItemName;
            this.FoodOrDrink = FoodOrDrink;
            this.FoodType = FoodType;
            this.LastDay = LastDay;
            this.Capacity = Capacity;
        }

        // Methods
        //CR: Don't implement algoritems by yourself anf the printing ui
        public override string ToString()
        {
            string s = "\nItem Name : " + this.ItemName + "\n";
            s += "Shelf Floor Number : " + this.ShelfFloorNumber + "\n";
            s += "Food Or Drink : " + this.FoodOrDrink + "\n";
            s += "FoodType : " + this.FoodType + "\n";
            s += "LastDay : " + this.LastDay + "\n";
            s += "Capacity : " + this.Capacity + "\n";

            return s;
        }
    }
}
