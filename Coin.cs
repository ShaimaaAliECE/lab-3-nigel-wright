using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
		public int Value;

		public Coin(string Description, int score, int value) : base(Description, score)
		{
			Value = value;
			Console.WriteLine($"{Description} Colleceted, Congrats!!!");
			UpdateTotaScore();
			UpdateTotalValue(); 
		}

		public void UpdateTotalValue()
		{
			totalValue += Value;
			Console.WriteLine("Total Value os updated to: " + totalValue);  
		}

        public override void Display()
        {
            string line = "Coin " + Description + " is displayed!";
            Console.WriteLine(line);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}

