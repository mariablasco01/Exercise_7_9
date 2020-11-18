using System;

    class digits
    {
        static void Main()
        {
            int oneNumber = 0, twoNumbers = 0, threeNumbers = 0, 
            moreThanThreeNumbers = 0;
            string textNumber = "";
                        
            while (textNumber != "end")
            {
                Console.Write("Insert a number (end to finish): ");
                textNumber = Console.ReadLine();
                
                if (textNumber != "end")
                {
					int number = Convert.ToInt32(textNumber);

					if (number != 0)
					{
						if (number / 10 == 0)
							oneNumber ++; 
						else

						if (number / 100 == 0)
							twoNumbers ++; 
						else
							
						if (number / 1000 == 0)
							threeNumbers ++;  
						else
							moreThanThreeNumbers++;
					}
				}
			}
			Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
			oneNumber, twoNumbers, threeNumbers, moreThanThreeNumbers); 
		}	
    }

