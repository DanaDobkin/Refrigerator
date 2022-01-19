using Refrigirator.BL.Actions.ItemActions;
using Refrigirator.CommonLayer.CreatingNewFridges;
using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintOrganizedFridges
    {
        // Properties
        private List<Fridge> Fridges;

        // Constructor
        public PrintOrganizedFridges()
        {
            CreatingManyFridges createFridges = new CreatingManyFridges();

            this.Fridges = createFridges.allFridges;;

            OrganizedFridgersInOrder organizedFridges = new OrganizedFridgersInOrder(this.Fridges);
            organizedFridges.PrintList();
        }
    }
}
