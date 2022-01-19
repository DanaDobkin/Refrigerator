using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewFridges
{
    class CreatingManyFridges
    {
        // Properties
        public List<Fridge> allFridges { get; set; }
        private const int _flag = -999;
        private const int _start = 1;

        // Constructror
        //CR: Functions in the class not need to be in the ctor
        //CR: Split it to diffrent class with his functions
        public CreatingManyFridges()
        {
            this.allFridges = new List<Fridge>();
            this.InputNewItem();
        }

        // Methods
        public void InputNewItem()
        {
            Console.WriteLine("You are going to start creating many Fridges. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());

            this.ValidateAnswer(answer);

            CreateOneNewFridge createFridges = new CreateOneNewFridge();

            while (answer != _flag)
            {
                this.allFridges.Add(createFridges.Fridge);
                Console.WriteLine("Continue? press " + -_start + " to continue, and " + _flag + "for ending.");
                answer = int.Parse(Console.ReadLine());
                this.ValidateAnswer(answer);
            }
        }

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
