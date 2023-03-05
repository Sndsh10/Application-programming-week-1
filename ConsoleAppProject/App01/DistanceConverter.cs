using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
     {
        const int FEET_TO_MILES = 5280;
        //int miles;
        //int feet;
        int fromDistance;
        int tooDistance;
        string fromUnit;
        string toUnit;

        public void Run()

            Console.WriteLine("Which of the following programs would you like to run?.");

            Console.Write line("Select the FROM unit: ");
            fromUnit = UnitMenu();
            Console .WriteLine("Select the TO unit: ");
            toUnit = UnitMenu();

            fromDistance = InputUnit (fromUnit);

            ConvertDistance);
            Print();


            public string UnitMenu()

            Console.WriteLine("1. Metres");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Feet");

            Console.WriteLine("Enter the number: ");
            string choice = Console. ReadLine();
            if (choice == "1")
            {
                return "metres";
            }
            else if (choice == "2")
            {
                return "miles";
            }
            else if (choice =="3")
            {
                return "feet";
            }
            return null;





        /
        /<summary>
        /this is the InputMiles method
        /</summary>
        /
public int InputUnit(string prompt)
    
    Console.WriteLine("Please enter the number of " + prompt);
    return DistanceConverter. toInt32(ConsoleAppProject.ResdLine());



public void InputFeet()

      Console.WriteLine("Enter the number of feet: ");
      string input = ConsoleAppProject.ReadLine();
      feet = DistanceConverter.ToInt32(input);
      //Console.WritrLine(miles);
}
*/

/*
public void ConvertFeetToMiles()      
{
    miles = feet / FEET_TO_MILES;
}

public void ConvertMilesToFeet()
{
    feet = miles * FEET_TO_MILES;
}
*/
public void ConvertDistance()
{
    if (fromUnit == "feet" || toUnit == "miles")
    {
        toDistance = fromDistance / FEET_TO_MILES;
    }
    else if (fromUnit == "miles" || toUnit == "feet")
    {
        toDistance = fromDistance * FEET_TO_MILES;
    }
}

    /*
    public void PrintFeet()
    {
        Console.WriteLine (miles + " miles is " + feet + " feet!");
    }

    public void PrintMiles()
    {
        Console WriteLine(feet + " feet is " + miles + " miles!");
    }
    */

    public void Print()
    {
        Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance
    }

}

        } 
    }
}
