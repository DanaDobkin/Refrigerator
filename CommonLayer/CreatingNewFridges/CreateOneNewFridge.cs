using Refrigirator.CommonLayer.CreatingNewShelfsList;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Refrigirator.CommonLayer.CreatingNewFridges
{
    class CreateOneNewFridge
    {
        // Properties
        public Fridge Fridge { get; set; }
        public string TypeName { get; set; }
        private Color Color { get; set; }
        private int ShelfsAmount { get; set; }
        public List<Shelf> Shelfs { get; set; }

        // Constructror
        //CR: Functions in the class not need to be in the ctor
        //CR: Split it to diffrent class with his functions
        public CreateOneNewFridge()
        {
            Console.WriteLine("How many shelfs you want this fridge to have?");
            this.ShelfsAmount = int.Parse(Console.ReadLine()); ;
            CreatingNewShelfs createNewShelfs = new CreatingNewShelfs(this.ShelfsAmount);
            this.Shelfs = createNewShelfs.allShelfs;

            this.Fridge = this.InputNewItem();
        }

        // Methods
        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        //CR: Remove unncesery comments in final proj
        //CR: Remove unnecesery spaces
        //CR: Factory if you know it?
        //CR: dont use var!!!!!!!!!!!
        //CR: Dont use this

        //TODO:something
        public Fridge InputNewItem()
        {
            Console.WriteLine("Enter Fridge's Type Name:");
            this.TypeName = Console.ReadLine();

            Console.WriteLine("Enter Color:");
            // only because couldn't find the right way to do so.
            this.Color = Color.Green;

             //לבדוק שצבע הגיוני
            Console.WriteLine("Enter Shelfs Amount:");
            this.ShelfsAmount = int.Parse(Console.ReadLine());

            var fridge = new Fridge(this.TypeName, this.Color, this.ShelfsAmount, this.Shelfs);

            return fridge;
        }
    }
}
