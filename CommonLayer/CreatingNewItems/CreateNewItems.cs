using Refrigirator.CommonLayer.CreatingNewItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.DAL
{
    class CreateNewItems
    {
        // Properties
        public List<Item> allItems { get; set; }
        private const int _flag = -999;
        private const int _start = 1;

        // Constructror
        //CR: Functions in the class not need to be in the ctor
        //CR: Split it to diffrent class with his functions
        public CreateNewItems()
        {
            this.allItems = new List<Item>();
            this.InputNewItem();
        }

        // Methods
        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        public void InputNewItem()
        {
            Console.WriteLine("You are going to start creating many items. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());
            
            this.ValidateAnswer(answer);

            CreateOneNewItem createItems = new CreateOneNewItem();

            while (answer == _start)
            {
                this.allItems.Add(createItems.Item);
                Console.WriteLine("Continue? press " + -_start + " to continue, and " + _flag + "for ending.");
                answer = int.Parse(Console.ReadLine());
                this.ValidateAnswer(answer);
            }
        }

        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        public void ValidateAnswer(int ans)
        {
            if (ans != _start && ans != _flag)
                while (ans != _start && ans != _flag)
                {
                    Console.WriteLine("Wrong input. Try again.");
                    ans = int.Parse(Console.ReadLine());
                }
        }
    }
}
