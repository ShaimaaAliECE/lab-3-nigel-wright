using System;
namespace Lab3App
{
	public class MagicWand : Tool
	{
        public MagicWand(string Description) : base(Description)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction();
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
    }
}

