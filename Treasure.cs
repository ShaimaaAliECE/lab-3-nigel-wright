using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure : Collectable 
	{
		public int Score;

		public Treasure(string Description, int score) : base(Description)
		{
			Score = score; 
		}

		public void UpdateTotaScore()
		{
			totalScore += Score;
			Console.WriteLine("Total Score is updated to: " + totalScore); 
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}

