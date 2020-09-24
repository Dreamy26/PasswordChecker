using System;

namespace Deliverable1_PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables we will use in this method
            string userInput;
            bool hasLowercase = false;
            bool hasUppercase = false;
            bool hasExclamationPoint = false;
            string errorMessage = "Error";
            string validMessage = "Password Valid and accepted";

            //Req 1 
            Console.WriteLine(
                    "Password should contain: " +
                    "\n - At least one lowercase letter" +
                    "\n - At least one uppercase letter" +
                    "\n - A minimum of 7 characters" +
                    "\n - A maximum of 12 characters" +
                    "\n - An exclamation point !");

            //Req 2  write will add a curser to the end or the :
            Console.Write("Enter the Password:");
            userInput = Console.ReadLine();

            //First check if password meets length requirements
            //Req 5, Req 6

            if (userInput.Length >= 7 && userInput.Length <= 12)
            {
                // If the password is the appropriate length, then iterate ofver the chars in the string
                for (int i = 0; i < userInput.Length && !(hasLowercase && hasUppercase && hasExclamationPoint); i++)
                {
                    char currentCharacter = userInput[i];
                    Console.WriteLine(currentCharacter);

                    //Req 3
                    if (char.IsLower(currentCharacter))
                    {
                        hasLowercase = true;
                    }
                    //Req 4
                    if (char.IsUpper(currentCharacter))
                    {
                        hasUppercase = true;
                    }

                    // Req 7
                    if (currentCharacter == '!')
                    {
                        hasExclamationPoint = true;
                    }
                }

                // IF all the character validation reqs have been met, congrats!
                if
                (hasLowercase && hasUppercase && hasExclamationPoint)
                {
                    Console.WriteLine(validMessage);
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
                
            }

            //The password doesn't meet length req, so error out

            else
            {
                Console.WriteLine(errorMessage);
            };
        }
    }
}
            


               

