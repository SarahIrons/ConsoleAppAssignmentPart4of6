using System;
using System.Linq;

//CONSOLE APP PART FOUR ASSIGNMENT

//Add the following to your console app and perform these actions:

//A list of strings where each item in the list is unique.

//Ask the user to input text to search for in the list.

//A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

//Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

//Add code that stops the loop from executing once a match has been found.
namespace ConsoleAppAssignmentPart4of6
{
    class Program
    {
        static void Main(string[] args)
        {//A list of strings where each item in the list is unique.
           
            string[] unique = { "distinctive", "individual", "quirky", "unrepeated","idiosyncratic" };
            
            //Ask the user to input text to search for in the list.

            Console.WriteLine("Is the \"unique\" synonym in this list? Enter word here:");
            //I imported Linq (language integrated query) to use the below operations. 
            bool result = unique.AsQueryable().Contains(Console.ReadLine());
            Console.WriteLine(result);
            //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
            //The line of code just above will return a true or false to show if the user entry is in the array(list) or not. 

  
            int index = 0;
            foreach (string value in unique)
            {
                //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

                Console.WriteLine($"{ index}:{ value}");
                index++;
            }

        }
    }
}
