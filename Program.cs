namespace FoodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredients recipe = new Ingredients();  /*W3schools.com. 1998*/

            Console.WriteLine("Welcome to the Food App!"); /*W3schools.com. 1998*/

            while (true)
                //This is the meun screen
            {
                Console.WriteLine("========================");
                Console.WriteLine("Menu:");/*W3schools.com. 1998*/
                Console.WriteLine("========================");
                Console.WriteLine("\n1. Enter Recipe Details"); /*W3schools.com. 1998*/
                Console.WriteLine("2. Display Recipe"); /*W3schools.com. 1998*/
                Console.WriteLine("3. Scale Recipe"); /*W3schools.com. 1998*/
                Console.WriteLine("4. Reset Quantities"); /*W3schools.com. 1998*/
                Console.WriteLine("5. Clear All Data"); /*W3schools.com. 1998*/
                Console.WriteLine("6. Exit"); /*W3schools.com. 1998*/

                Console.Write("Enter your choice: "); /*W3schools.com. 1998*/ 
                string choice = Console.ReadLine(); /*W3schools.com. 1998*/

                switch (choice) /*W3schools.com. 1998*/
                {
                    //These are my methods
                    case "1":
                        recipe.EnterDetails(); 
                        break;
                    case "2":
                        recipe.Display(); 
                        break; /*W3schools.com. 1998*/
                    case "3":
                        recipe.Scale(); 
                        break;
                    case "4":
                        recipe.ResetQuantities(); 
                        break; /*W3schools.com. 1998*/
                    case "5":
                        recipe.ClearData(); 
                        break; /*W3schools.com. 1998*/
                    case "6":
                        //If you are done now the app is done
                        Console.WriteLine("Thank you for using the Food App. Goodbye!"); /*W3schools.com. 1998*/
                        return;
                    default:
                        //This handles the error if the you or user enter number that is not 1 to 6
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6."); /*W3schools.com. 1998*/
                        break; /*W3schools.com. 1998*/
                }
            }
        }
    }
}

//W3schools.com. 1998.Get started with C#. [Online] Available at: https://www.w3schools.com/cs/cs_getstarted.php  (Accessed:  16 March 2024). 

//GeeksforGeeks.2019 Console.Clear method in C#, [Online].  Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).

//W3schools.com. 1998. C# switch Available at: https://www.w3schools.com/cs/cs_switch.php (Accessed: April 16, 2024).
