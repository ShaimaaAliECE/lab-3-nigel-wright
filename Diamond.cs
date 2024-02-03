using System;
namespace Lab3App
{
	public class Diamond : Treasure
	{
		public Diamond(string Description, int score) : base(Description, score)
		{
			Console.WriteLine($"{Description} Collected, Congrats!!!");
			UpdateTotaScore(); 
		}

        public override void Display()
        {
            string line = "Diamond " + Description + "is displayed!";
            Console.WriteLine(line);
        }
    }
}

