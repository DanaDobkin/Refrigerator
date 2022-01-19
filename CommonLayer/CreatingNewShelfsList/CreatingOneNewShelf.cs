using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewShelfsList
{
    class CreatingOneNewShelf
    {
        // Properties
        public Shelf Shelf { get; set; }

        public int FloorNumber { get; set; }
        public int FreeSpace { get; set; }
        public List<Item> Items { get; set; }

        // Constructor
        public CreatingOneNewShelf()
        {
            CreateNewItems createItems = new CreateNewItems();
            this.Items = createItems.allItems;

            this.Shelf = this.InputNewItem();
        }

        public Shelf InputNewItem()
        {
            Console.WriteLine("Enter Shelf's Floor Number:");
            this.FloorNumber = int.Parse(Console.ReadLine());

            this.VerifyFloorNumber();

            Console.WriteLine("Enter Free Space:");
            this.FreeSpace = int.Parse(Console.ReadLine());

            this.VerifyFreeSpace();

            var shelf = new Shelf(this.FloorNumber, this.FreeSpace, this.Items);

            return shelf;
        }

        public void VerifyFloorNumber()
        {
            if (this.FloorNumber < 0)
                while (this.FloorNumber < 0)
                {
                    Console.WriteLine("Wrong input. Try again.");
                    this.FloorNumber = int.Parse(Console.ReadLine());
                }
        }

        public void VerifyFreeSpace()
        {
            if (this.FreeSpace < 0)
                while (this.FreeSpace < 0)
                {
                    Console.WriteLine("Wrong input. Try again.");
                    this.FreeSpace = int.Parse(Console.ReadLine());
                }
        }
    }
}
