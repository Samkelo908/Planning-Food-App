using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ingredients
{
    private string[] ingredients; /*W3schools.com. 1998*/ //This is the array for ingredients
    private string[] steps;  /*W3schools.com. 1998*/ //This is the array for steps
    private double[] quantities; /*W3schools.com. 1998*/ //This is the array for quantities
    private double[] originalQuantities;  /*W3schools.com. 1998*/ //This is the array original quantities
    private string[] units; /*W3schools.com. 1998*/ // This is the array units
    private int numberOfIngredients; /*W3schools.com. 1998*/
    private int numberOfSteps; /*W3schools.com. 1998*/ // This is the array for the number of steps

    public Ingredients()
    {
        ingredients = new string[10]; /*W3schools.com. 1998*/
        steps = new string[10]; //This is the array for ingredients
        quantities = new double[10]; /*W3schools.com. 1998*/
        originalQuantities = new double[10];  //This is the array for ingredients
        units = new string[10]; /*W3schools.com. 1998*/
    }
    //Entering the details method
    public void EnterDetails() /*W3schools.com. 1998*/
    {
        //I have justed while loop so that it can handle the errors
        while (true)  /*Stack Overflow. 2008*/ 
        {
            Console.Write("Number of ingredients: ");/*W3schools.com. 1998*/
            bool isValidInput = int.TryParse(Console.ReadLine(), out numberOfIngredients); /*Stack Overflow. 2008*/


            if (!isValidInput || numberOfIngredients <= 0)  /*Stack Overflow. 2008*/
            {
                Console.WriteLine(" Number is incorrect. Please enter a positive Number for ingredients.");// Enter the number of ingredients.
                continue; /*W3schools.com. 1998*/
            }


            ingredients = new string[numberOfIngredients]; /*W3schools.com. 1998*/
            quantities = new double[numberOfIngredients]; /*W3schools.com. 1998*/
            units = new string[numberOfIngredients]; /*W3schools.com. 1998*/

            for (int i = 0; i < numberOfIngredients; i++)  /*W3schools.com. 1998*/
            {
                Console.Write($"Enter Recipe #{i + 1} name: ");
                ingredients[i] = Console.ReadLine();

                Console.Write($"Enter quantity of {ingredients[i]}: ");
                isValidInput = double.TryParse(Console.ReadLine(), out quantities[i]);  /*Stack Overflow. 2008*/

                if (!isValidInput || quantities[i] <= 0)
                {
                    Console.WriteLine("Number is incorrect. Please enter a positive number for the quantity.");/*W3schools.com. 1998*/
                    continue; //After getting this error the can continue with adding
                }

                Console.Write($"Enter unit of measurement for {ingredients[i]}: "); 
                units[i] = Console.ReadLine();
            }

            
            originalQuantities = (double[])quantities.Clone();

            Console.Write("Enter the number of steps: "); /*W3schools.com. 1998*/
            isValidInput = int.TryParse(Console.ReadLine(), out numberOfSteps);   /*Stack Overflow. 2008*/

            if (!isValidInput || numberOfSteps <= 0)  /*Stack Overflow. 2008*/
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of steps.");  /*Stack Overflow. 2008*/
                continue; //if you enter the wrong thing you will get this error
            }

            steps = new string[numberOfSteps]; /*W3schools.com. 1998*/

            for (int i = 0; i < numberOfSteps; i++)
            {
                Console.Write($"Enter step #{i + 1}: ");
                steps[i] = Console.ReadLine();
            }
            //As you see this is the the recips have been added

            Console.WriteLine("Recipe details entered successfully!"); /*W3schools.com. 1998*/
            break;
        }
    }
    //This is the the display method
    public void Display() /*W3schools.com. 1998*/
    {
        Console.WriteLine("\nRecipe Details:"); /*W3schools.com. 1998*/ //The user will see this after the display
        Console.WriteLine("Ingredients:"); /*W3schools.com. 1998*/

        for (int i = 0; i < numberOfIngredients; i++) /*W3schools.com. 1998*/
        {
            Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}"); 
        }

        Console.WriteLine("\nSteps:"); /*W3schools.com. 1998*/

        for (int i = 0; i < numberOfSteps; i++)  /*W3schools.com. 1998*/
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }
    //This is the Scale method
    public void Scale() /*W3schools.com. 1998*/
    {
        // The user will get to see this and enter the scale they want
        Console.Write("Enter the scaling factor (0.5 for half, 2 for double, 3 for triple): "); /*W3schools.com. 1998*/
        double factor = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfIngredients; i++) /*W3schools.com. 1998*/
        { 
            quantities[i] *= factor;
        }

        Console.WriteLine("Recipe scaled successfully!"); /*W3schools.com. 1998*/
    }

    public void ResetQuantities() /*W3schools.com. 1998*/
    {
        for (int i = 0; i < numberOfIngredients; i++)
        {
            quantities[i] = originalQuantities[i]; /*W3schools.com. 1998*/
        }

        Console.WriteLine("Quantities reset successfully!"); /*W3schools.com. 1998*/
    }

    public void ClearData()/*W3schools.com. 1998*/
    {
        //This is my clear array that clears everything when you pick 5
        Array.Clear(ingredients, 0, ingredients.Length); /*W3schools.com. 1998*/
        Array.Clear(steps, 0, steps.Length); /*W3schools.com. 1998*/
        Array.Clear(quantities, 0, quantities.Length); /*W3schools.com. 1998*/
        Array.Clear(units, 0, units.Length); /*W3schools.com. 1998*/
        Array.Clear(originalQuantities, 0, originalQuantities.Length);  /*W3schools.com. 1998*/
        numberOfIngredients = 0;
        numberOfSteps = 0; /*W3schools.com. 1998*/

        Console.WriteLine("All data cleared successfully!"); /*W3schools.com. 1998*/
    }


}


//W3schools.com. 1998.Get started with C#. [Online] Available at: https://www.w3schools.com/cs/cs_getstarted.php  (Accessed:  16 March 2024). 


//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).


//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).

//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).
