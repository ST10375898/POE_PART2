using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_2_VERSION_2._0
{
    public delegate string calWarning(double calory);
    public class Recipe
    {
        // declaration of properties of Recipe objects
        private string recipeName;
        private List<Ingredient> ingredients;
        private List<Step> steps;
       
        // getters and setters of the properties
        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; }
        }



        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        
        public List<Step> Steps
        {
            get { return steps; }
            set { steps = value; }
        }
        // a constructer to accept the name of a recipe, an array of ingredient and an array of ingredients
        public Recipe(string recipeName, List<Ingredient> ingredients, List<Step> steps)
        {
            this.RecipeName = recipeName;
            this.Ingredients = ingredients;
            this.Steps = steps;
        }
        // method to display the detials of the recipes
        public void displayRecipe(double scale)
        {
            Console.WriteLine($"-------------------- Recipe Name: {recipeName} ---------------------");
            Console.WriteLine("------------------------------INGREDIANTS----------------------------");
            Console.WriteLine();
            double caloryCount = 0;
            // for loop displaying the ingredients of a recipe
            for(int i=0; i<ingredients.Count; i++)
            {
                Console.WriteLine($"{i+1}. {ingredients[i].Quantity*scale} {ingredients[i].Unit} {ingredients[i].Name}. (Food Group: " +
                                  $"{ingredients[i].FoodGroup} | Calories: {ingredients[i].Calory*scale} )");
                caloryCount += ingredients[i].Calory;
            }
            Console.WriteLine();
            // calory warning method used to produce warning to user if the calory count is too high
            Console.WriteLine("--------------------------------------------------------------------");
            calWarning warn = CaloryWarning;
            Console.WriteLine($"Total Calories: {caloryCount*scale}");
            Console.WriteLine(warn.Invoke(caloryCount*scale));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            // displaying the steps and their descriptions
            for (int j=0; j<steps.Count; j++)
            {
                Console.WriteLine($"Step {j+1} > {steps[j].Description}");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------- End of Recipe ----------------------------");
        }
        //caloryWarning method to display the calory warning if the recipe contains calories higher than 300
        public string CaloryWarning(double calories)
        {
            string output="";
            if(calories >= 300)
            {

                output = $"***************************************************************\n" +
                         $"High Calory Warning! (Recipe contains more than 300 calories)\n" +
                         $"****************************************************************";
            }
            
            return output;
        }
        //method used to display the menu to be used in the system
        public string displayMenu(string name)
        {
            string menu = $"Please choose desired Scale for {name} Recipe  > \n"+
                              "1. Display at original Scale.\n" +
                              "2. Display at Double scale.\n" +
                              "3. Display at Triple scale\n" +
                              "4. Display at half Scale\n" +
                              "5. Exit";
            return menu;
        }
    }
}
