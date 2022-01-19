using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    
    //CR: Function not in a class
    class AllShelfsByEmptySpace
    {
        // Properties
        private Fridge Fridge;
        private List<Shelf> freeSpace;

        // Constructor
        public AllShelfsByEmptySpace(Fridge Fridge)
        {
            this.Fridge = Fridge;
            this.freeSpace = new List<Shelf>();
            this.GetMaxShelfSpace(this.Fridge.Shelfs);
        }

        // Methods
        public void PrintList()
        {
            foreach (Shelf s in this.freeSpace)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public void GetMaxShelfSpace(List<Shelf> shelfs)
        {
            double maxSpace = shelfs[0].FreeSpaceOnShelf();
            int maxIndex = 0;

            while (shelfs != null)
            {
                for (int i = 1; i < shelfs.Count; i++)
                {
                    if (shelfs[i] != null && shelfs[i].FreeSpace > maxIndex)
                    {
                        maxSpace = shelfs[i].FreeSpace;
                        maxIndex = i;
                    }
                }

                this.freeSpace.Add(shelfs[maxIndex]);
                shelfs.RemoveAt(maxIndex);

                maxSpace = shelfs[0].FreeSpaceOnShelf();
                maxIndex = 0;
            }
        }
    }
}
