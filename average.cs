using System;

	public class Average
	{
		public static void Main()
		{
			double sum = 0, number = 0, counter = 0, average = 0;
			string numberText = "";
	 
			do
			{
				Console.Write("Insert a mark (end to finish): ");
				numberText = Console.ReadLine();
				
				if (numberText != "end")
				{					
					number = Convert.ToDouble(numberText);
					counter++;                             
					sum += number; 
				}				
			}
			while (numberText != "end");
			
			if (counter != 0)
			{
				average = sum / counter; 
				Console.WriteLine("The average is {0}.",average);
			}
		}	
	}
