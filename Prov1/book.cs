using System;
using System.Collections.Generic;

namespace Prov1
{
    public class book
    {
        public int price;

        private string name;

        private int rarity;

        private string category;

        private int actualValue;

        private bool cursed;

        Random generator = new Random();

        private List<string> kategori = new List<string>() { "Adventure", "Horror", "Facts", "Detective", "Informative" };

        private List<string> Title = new List<string>() { "The Lost World", "The Missing Mask", "The Sanctuary Of The Exiled", "Year of Death", "The Day before Yesterday" };

        public book()
        {
            actualValue = generator.Next(100000);

            rarity = generator.Next(10);

            int chance = generator.Next(10000);
            if (chance > 7500)
            {
                cursed = true;
            }
            else if (chance <= 7500)
            {
                cursed = false;
            }

            int whatCategory = generator.Next(kategori.Count);
            category = kategori[whatCategory];

            int whatTitle = generator.Next(Title.Count);
            name = Title[whatCategory];
        }


        public void PrintInfo()
        {
            Console.WriteLine("This book is called ''" + name + "''.");
            Console.WriteLine(name + "'s rarity is: " + rarity + "/10");
            Console.WriteLine(name + " is categorised as: " + category + ".");
            Console.WriteLine(name + " is worth " + actualValue + "coins");
            Console.WriteLine("The actualprice is: " + Evaluate() + "coins because of its rarity.");
        }

        public int Evaluate()
        {
            int Value = actualValue * rarity;

            double percentage = 0.5 + (1.5 - 0.5) * generator.NextDouble();

            int percent = Convert.ToInt32(percentage);

            int price = percent * Value;

            return price;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        // public bool IsCursed()
        // {
            
        // }
    }
}
