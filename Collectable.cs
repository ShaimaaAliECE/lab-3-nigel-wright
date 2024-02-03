using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Collectable : CollectionBoard, Displayable
	{
		public string Description;

		private CollectionBoard board;

		public CollectionBoard Board
		{
			get
			{
				return board;
			}
			set
			{
				board = value; 
			}
		}

		public Collectable(string Description) 
		{
            this.Description = Description;
        }

		public virtual void AddMe(List<Collectable> list)
		{
			list.Add(this); 
		}

		public abstract void Display(); 
	}
}

