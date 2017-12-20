using System;

   public int Calculations
{

    class Calculations
{
    public int AskUserForNumber()


        Console.WriteLine("please enter number");
        //ielasit ciparu no konsoles
        int number;
    //ieskaita 

    bool success = Int32.TryParse(inputText, out number);
    
      if (sucess == false)
      {
        Console.WriteLine("Sorry wrong value entered");
        number = AskUserForNumber();
      }

    return number;
	}
}
]