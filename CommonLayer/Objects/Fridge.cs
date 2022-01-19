using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Refrigirator
{
    // CR: On layers you need to know why you creating them
    // CR: Common layer is the core of the project, it stores all the the basic models for the rest of the layers
    //CR: This a model you nedd only the properties
    //
    class Fridge
    {
        // Properties
        public string TypeName { get; set; }
        private Color Color { get; set; }

        //CR: private need to be _shlelfsAmount
        private int ShelfsAmount { get; set; }
        public List<Shelf> Shelfs { get; set; }

        // Constructor
        //CR: Variables in lowercase
        public Fridge(string TypeName, Color Color, int ShelfsAmount, List<Shelf> Shelfs)
        {
            this.TypeName = TypeName;
            this.Color = Color;
            this.ShelfsAmount = ShelfsAmount;
            this.Shelfs = Shelfs;
        }

        //CR: The print needs to be in the ui layer
        //CR: You don't need to implement by yourself known algorithems
        // Methods
        public double EmptySpaceInAllFridge()
        {
            //double freeSpace = 0;
            //if (Shelfs is null)
            //{
            //    return -1;
            //}

            //Shelfs.ForEach(shelf => GetFreeSpace(freeSpace, shelf))
            //return freeSpace;


            if (!(this.Shelfs is null))
            {
                double freeSpace = 0;

                foreach (Shelf shelf in this.Shelfs)
                {
                    if (shelf != null)
                        freeSpace += shelf.FreeSpaceOnShelf();
                }

                return freeSpace;
            }
            else
                Console.WriteLine("There are no shelfs");

            return -1;
        }

        //private double GetFreeSpace(double freeSpace, Shelf shelf)
        //{
        //    if(shelf is null)
        //    {
        //        return freeSpace;
        //    }

        //    return shelf.FreeSpaceOnShelf() + freeSpace;
        //}
        
        //CR: Don't implement algoritems by yourself anf the printing ui
        public override string ToString()
        {
            string s = "Refrigiratoe's Type Name : " + this.TypeName;
            s += "\nColor: " + this.Color;
            s += "\nShelfs Amount : " + this.ShelfsAmount;
            s += "\nShelfs :\n";

            for (int i = 0; i < this.Shelfs.Count; i++)
            {
                s += "\nShelf number " + (i + 1) + " \n";
                s += this.Shelfs[i].ToString();
            }

            return s;
        }
    }
}
