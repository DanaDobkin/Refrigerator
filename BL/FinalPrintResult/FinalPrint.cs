using Refrigirator.BL.Actions;
using Refrigirator.BL.Actions.PrintingActions;
using Refrigirator.CommonLayer.CreatingNewFridges;
using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.FinalPrintResult
{
    class FinalPrint
    {
        // Properties
        private Fridge Fridge;

        // Constructorl
        public FinalPrint()
        {
            // Part 1 
            Console.WriteLine("Your Fridge: ");
            CreateOneNewFridge createFridges = new CreateOneNewFridge();
            this.Fridge = createFridges.Fridge;

            //Part 2
            //PrintLeftFreeSpaceInFridge leftSpace = new PrintLeftFreeSpaceInFridge(this.Fridge);

            //Console.WriteLine("Fridge Consistency: ");
            //PrintAllFridgeConsistency fridgeConsistency = new PrintAllFridgeConsistency(this.Fridge);

            //TakeOutAnItem takeOutItem = new TakeOutAnItem(this.Fridge);

            //PrintAddingNewItem putNewItemIn = new PrintAddingNewItem(this.Fridge);

            //FridgeCleaning cleanFridge = new FridgeCleaning(this.Fridge);

            //PrintWhatYouWantToEat wantToEat = new PrintWhatYouWantToEat(this.Fridge);

            ////These three following functions are based on the same structure,
            ////And all return the same error, which is about index:

            //// Doesn't Work
            //PrintAllExpiredDatesInOrder expiredDates = new PrintAllExpiredDatesInOrder(this.Fridge);

            //// Doesn't Work
            //OrganizedShelfsInOrder organizedShelfs = new OrganizedShelfsInOrder(this.Fridge);

            //// Doesn't Work
            //PrintOrganizedFridges organizedFridges = new PrintOrganizedFridges();

            //// Part 3
            //PrintGettingRidOf goingShopping = new PrintGettingRidOf(this.Fridge);
        }
    }
}
