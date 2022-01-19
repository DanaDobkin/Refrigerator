using Refrigirator.CommonLayer.CreatingNewShelfsList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewShelfsList
{
    class CreatingNewShelfs
    {
        // Properties
        public List<Shelf> allShelfs { get; set; }
        private const int _flag = -999;
        private const int _start = 1;
        private int amount;

        // Constructror
        //CR: Functions in the class not need to be in the ctor
        //CR: Split it to diffrent class with his functions
        public CreatingNewShelfs(int amount)
        {
            this.amount = amount;
            this.allShelfs = new List<Shelf>();
            
            //Example to class that u use
            //var a = new fsadfs();
            //a.

            this.InputNewShelf();
        }

        // Methods
        //CR: Don't use cw in common layer
        //CR: Don't implement the algorithem
        //CR: SRP
        public void InputNewShelf()
        {
            Console.WriteLine("You are going to start creating many shelfs. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());

            this.ValidateAnswer(answer);

            CreatingOneNewShelf createShelf = new CreatingOneNewShelf();
            
            for (int i = 0; i < this.amount; i++)
            { 
            
                this.allShelfs.Add(createShelf.Shelf);
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
