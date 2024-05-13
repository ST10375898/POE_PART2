using POE_2_VERSION_2._0;

internal class Program
{
    private static void Main(string[] args)
    {

        //declarations
        List<Recipe> recipes = new List<Recipe>(); // generic array of Recipe objects
        List<String> recipeNames = new List<String>();// array list to store the names of arrays
        string final = "";
        
        // prompting user for input
        Console.WriteLine("Would you like to enter a recipe (Y/N)");
        string option = Console.ReadLine().ToUpper();
        while (option != "Y" && option != "N")
        {
            Console.Write("Please enter (Y/N) to proceed > ");
            option = Console.ReadLine().ToUpper();
        }
        int index = 0;
        while (option == "Y")
        {
            string resName = "";
            Console.Write($"Enter name of Recipe number {index + 1} > ");
            resName = Console.ReadLine();
            recipeNames.Add(resName);
            
            
            int numIngredients = 0;

            bool isValid = false;// error handling for format exception when user is entering number of ingredients
            while (!isValid)
            {
                try
                {
                    Console.Write($"Enter number of ingredients for {resName} recipe  > ");
                    numIngredients = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter a number.");
                }
            }
            // declaration of array of ingredient objects
            List<Ingredient> ingredients = new List<Ingredient>();
            // for loop to capture the details of each ingredient
            for (int i = 0; i < numIngredients; i++)
            {
                
                Console.WriteLine($"------------ Enter Ingredient {i+1} Details ---------------");
                Console.Write($"Enter ingredient {i + 1} name > ");
                string ingredientName = Console.ReadLine();
                double quantity = 0;
                double calory = 0;
                bool isValid1 = false;
                while (!isValid1)// format exception handling for quantity of ingredients
                {
                    try
                    {
                        Console.Write($"Enter the quantity of {ingredientName} > ");
                        quantity = Convert.ToDouble(Console.ReadLine());
                        isValid1=true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input! Please enter a number.");
                    }
                }
              
                Console.Write($"Enter measure of unit of quantity > ");
                string unit = Console.ReadLine();

                Console.Write($"Enter {ingredientName} food group > ");
                string foodGroup = Console.ReadLine();

                bool isValid2 = false;
                while (!isValid2) // format exception handling for the calories if user enters string or character input
                {
                    try
                    {
                        Console.Write($"Enter {ingredientName} calories > ");
                        calory = Convert.ToDouble(Console.ReadLine());
                        isValid2 = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input! Please enter a number.");
                    }
                }
                ingredients.Add(new Ingredient(ingredientName,quantity,unit,foodGroup,calory));
            }
            int numSteps = 0;
            bool isValid3 = false;
            while (!isValid3) // format exception handling for number of steps if user user enters string or character input
            {
                try
                {
                    Console.Write($"Enter number of Steps of {resName} Recipe > ");
                    numSteps = Convert.ToInt32(Console.ReadLine());
                    isValid3 = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter a number.");
                }
            }
            // declaration of array of Step objects
            List<Step> steps = new List<Step>();
            // for loop to capture the details of each step
            for (int j = 0; j < numSteps; j++)
            {
                
                Console.Write($"Enter step {j + 1} > ");
                string step = Console.ReadLine();
                steps.Add(new Step(step));
            }
            // adding a new recipe object to Recipe generic list
            recipes.Add(new Recipe(resName, ingredients, steps));
            index++;
            // prompting user for additional recipe
            Console.WriteLine("Would you like to enter a recipe (Y/N)");
            option = Console.ReadLine().ToUpper();
            while (option != "Y" && option != "N")
            {
                Console.Write("Please enter (Y/N) to proceed > ");
                option = Console.ReadLine().ToUpper();
            }
            
        }
        int decision = 0;
        // checking if there are any new recipes
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes to Display. Thank you Bye!");
        }
        else
        {
            do
            {
                int opt = 0;
                bool isValid4 = false;
                while (!isValid4) // format exception handling for the option number the user chooses
                {
                    try
                    {
                        recipes.Sort((x,y) => string.Compare(x.RecipeName,y.RecipeName));
                        Console.WriteLine($"Please choose recipe to display details > ");
                        for (int i = 0; i < recipeNames.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {recipes[i].RecipeName}");
                        }
                        decision = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(recipes[decision - 1].displayMenu(recipes[decision - 1].RecipeName));
                        opt = Convert.ToInt32(Console.ReadLine());
                        isValid4 = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input! Please enter a number.");
                    }
                }

                // while loop to keep prompting user for different options until the user enters option 5
                while (opt != 5)
                {
                    // switch to display recipe at different scales
                    switch (opt)
                    {
                        // display recipe at original scale
                        case 1:
                            recipes[decision - 1].displayRecipe(1);
                            bool isValid5 = false;
                            while (!isValid5) // format exception handling for option number
                            {
                                try
                                {
                                    Console.WriteLine(recipes[decision - 1].displayMenu(recipes[decision - 1].RecipeName));
                                    opt = Convert.ToInt32(Console.ReadLine());
                                    isValid5 = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid Input! Please enter a number.");
                                }
                            }
                            
                            break;
                        // display recipe at double scale
                        case 2:
                            recipes[decision - 1].displayRecipe(2);
                            bool isValid6 = false;
                            while (!isValid6) // format exception handling for option number
                            {
                                try
                                {
                                    Console.WriteLine(recipes[decision - 1].displayMenu(recipes[decision - 1].RecipeName));
                                    opt = Convert.ToInt32(Console.ReadLine());
                                    isValid6 = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid Input! Please enter a number.");
                                }
                            }
                            
                            break;
                        // display recipe at triple scale
                        case 3:
                            recipes[decision - 1].displayRecipe(3);
                            bool isValid7 = false;
                            while (!isValid7) // format exception handling for option number
                            {
                                try
                                {
                                    Console.WriteLine(recipes[decision - 1].displayMenu(recipes[decision - 1].RecipeName));
                                    opt = Convert.ToInt32(Console.ReadLine());
                                    isValid7 = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid Input! Please enter a number.");
                                }
                            }
                            
                            break;
                        // display recipe at half scale
                        case 4:
                            recipes[decision - 1].displayRecipe(0.5);
                            bool isValid8 = false;
                            while (!isValid8) // format exception handling for option number
                            {
                                try
                                {
                                    Console.WriteLine(recipes[decision - 1].displayMenu(recipes[decision - 1].RecipeName));
                                    opt = Convert.ToInt32(Console.ReadLine());
                                    isValid8 = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid Input! Please enter a number.");
                                }
                            }
                            
                            break;

                        default:
                            opt = 5;
                            break;
                    }
                }
                // prompting user if they want to exit or display a different recipe

                    Console.Write("Press Y to show another Recipe or N to exit > ");
                    final = Console.ReadLine().ToUpper();
                    while (final != "Y" && final != "N")
                    {
                        Console.Write("Please enter (Y/N) to proceed > ");
                        final = Console.ReadLine().ToUpper();
                    }
            } while (final == "Y");
        }
        Console.Write("Thank You for using system. Bye!");
    }
}