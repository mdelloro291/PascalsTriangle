using System;

class Program {
	public static void Main (string[] args) {
		string input = Console.ReadLine();
		int rows = Convert.ToInt32(input);
		int value = 1;
		int totalAbove = 0;
		int totalBelow = 0;
		//--rows;
		
		if(Int32.TryParse())
		{
			
		}
		for(int countOne = 0; countOne <= rows + 1; ++countOne)
		{
			for(int countTwo = 0; countTwo <= countOne; ++countTwo)
			{
				if(countOne == 0 || countTwo == 0 )
				{
					value = 1;
				}
				else
				{
					value = value * (countOne - countTwo + 1) / countTwo;
				}
				if(countOne < rows){
					totalAbove += value;
				}
				else if(countOne == rows + 1){
					totalBelow += value;
				}
			}
			Console.WriteLine("");
		}
		Console.WriteLine(totalAbove + " " + totalBelow);
		Console.ReadKey();
	}
}