using CourierSystem.Models;
using CourierSystem.Services;

namespace CourierSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "1ST QUESTION"
            /*1. Write a program that checks whether a given order is delivered or not based on its status (e.g., 
"Processing," "Delivered," "Cancelled"). Use if-else statements for this. */

            /*   string status = "Delivered";

               if (status.Equals("Delivered"))
               {
                   Console.WriteLine("Order is delivered!");
               }
               else if (status.Equals("Processing"))
               {
                   Console.WriteLine("Order is being processed!");
               }
               else if (status.Equals("Cancelled"))
               {
                   Console.WriteLine("Order is Cancelled");
               }*/
            #endregion

            #region "2ND QUESTION"
            /*2. Implement a switch-case statement to categorize parcels based on their weight into "Light," 
"Medium," or "Heavy."*/
            /* Console.WriteLine("Enter the weight:");
             int weight = int.Parse(Console.ReadLine());

             switch (weight)
             {
                 case int w when w >= 0 && w <= 500:
                     Console.WriteLine("Light");
                     break;
                 case int w when w > 500 && w <= 1000:
                     Console.WriteLine("Medium");
                     break;
                 case int w when w > 1000:
                     Console.WriteLine("Heavy");
                     break;
             }
 */
            #endregion

            #region "3RD QUESTION"

            /*3. Implement User Authentication 1. Create a login system for employees and customers using Java 
control flow statements. */

            /* string userName = "user13";
             string password = "12345";
             bool isValid = false;
             while (!isValid)
             {
                 Console.WriteLine("Enter your username:");
                 string userInput = Console.ReadLine();
                 Console.WriteLine("Enter your password:");
                 string passInput = Console.ReadLine();

                 if (userName.Equals(userInput) && password.Equals(passInput))
                 {
                     Console.WriteLine("Welcome user!!!");
                     isValid = true;
                     break;
                 }
                 else if (userName.Equals(userInput) && !(password.Equals(passInput)))
                 {
                     Console.WriteLine("Your password is incorrect!!");
                 }
                 else if (!(userName.Equals(userInput)) && password.Equals(passInput))
                 {
                     Console.WriteLine("Username not found!!");
                 }
                 else
                 {
                     Console.WriteLine("Your credentials are incorrect");
                 }
             }*/
            #endregion

            CourierSystemApp app = new CourierSystemApp();
            app.Menu();
        }
    }
}
