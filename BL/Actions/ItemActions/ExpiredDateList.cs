using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{

    //CR: Function not in a class
    class ExpiredDateList
    {
        // Properties
        private Fridge Fridge;
        private List<DateTime> expiryDates;
        private List<DateTime> allDates;
        private DateTime oldestDate;

        // Constructor
        public ExpiredDateList(Fridge Fridge)
        {
            this.Fridge = Fridge;
            this.expiryDates = new List<DateTime>();
            this.allDates = this.GetAllDates();
            this.oldestDate = this.allDates[0];
            this.OrderAllDatesInList();

        }

        // Methods
        public List<DateTime> GetAllDates()
        {
            List<DateTime> Dates = new List<DateTime>();

            if (this.Fridge != null && this.Fridge.Shelfs != null)
                foreach (Shelf s in this.Fridge.Shelfs)
                    if (s != null && s.Items != null)
                        foreach (Item i in s.Items)
                        {
                            if (i != null)
                                Dates.Add(i.LastDay);
                        }

            return Dates;
        }

        public void PrintList()
        {
            foreach (DateTime d in this.expiryDates)
            {
                Console.WriteLine(d.ToString());
            }
        }

        public void GetMinDate()
        {
            if (this.allDates != null)
            {
                int minIndex = 0;

                for (int i = 1; i < this.allDates.Count; i++)
                {
                    if (this.allDates[i] != null && this.allDates[i] < this.oldestDate)
                    {
                        this.oldestDate = this.allDates[i];
                        minIndex = i;
                    }
                }

                this.allDates.RemoveAt(minIndex);
            }
        }

        public void OrderAllDatesInList()
        {
            if (this.expiryDates != null && this.allDates != null)
            {
                while (this.allDates != null)
                {
                    this.GetMinDate();
                    this.expiryDates.Add(this.oldestDate);
                }
            }
        }
    }
}
