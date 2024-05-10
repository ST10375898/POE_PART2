## POE_PART2
## This repository contains a console application written in C# that captures the details of a recipe (Ingredient details and steps) and desplays them at different scales as chosen by the user.
This application is built for chefs, people in the calinary field and everyday food lovers that would like to record and store their favorite recipes in a computer program. The program will not only take on the recipe but it will also provide the following fucntionalities to manipulate the details of the recipe: 

* Create a new recipe
* Enter new recipe ingrediant and steps
* Scale recipe by a factor of 1 or 2 or 3 or 0.5.
* Scace the recipe back to normal values.
* Clear a recipe and enter a new recipe.

The part about scaling basically allows the user to half, double or triple the original measurements of the recipe ingrediants. This is done incase a user would like to icrease the amount of output product that a recipe produces at original scale.
## Changes and Improvements
This console application is based on a project in the following repository (<a href="https://github.com/ST10375898/Recipe_System_Part1"> Part1 Repository</a>) and is the part 2 of the project in the mentioned repository. The application has been improved and significant changes have been made and are listed as follows:
* The user can now enter an unlimited number of recipes
* The user can now add the following data as part of the data of an ingredient:
  1. Ingredient Food group. This piece of information states the food group to which the ingredient belongs to. Some examples of good groups include carbohydrates, proteins and fats.
  2. Ingredient Calories. This states the calory count of an igredient.
* The application can now display the total calory count of all ingredient within a recipe. The application can also now detect if a certain recipe has a calory count higher than 300 and issue a high calory warinng to the user.
## Lecture recommendations
* Our lecturer has advised a change to the overall structure of the main method, so the following changes have been made:
  1. The main method uses methods to display details such as the menu that appear multiple times in the program with the same lines of code.
  2. The main method now relies on the instantion of objects and accessing the object properties and methods instead of declaring local variables and methods that are static.
* These changes have improved our application in that we are now able to use the method of one class in a different class because the methods are not static.
## Basic system diagram image
<img src="Screenshot (177).png" width="" height="500px" alt="Image of basic system functionalities.">

## User instructions
1. Clone project from git hub.
2. If you cannot clone project just download project as a file.zip and extract file contents once the are extracted.
3. Open Microsoft Visual studio or your IDE of choice that can run a C# console application that does of .NET VERSION 8 long-term support. (It is advisable to open project using Microsoft visual studio with .NET Version 8 to avoid running into any incompatibility issues that may arise.).
4. Once project is open view the solution on IDE and run solution.
5. Upon running the application a console will appear and ask the if they would like to enter a recipe. The program then prompts the user for the number of ingredients and the number of steps of the recipe.
6. The application will now prompt you to enter the following details about each ingredient:
    - The name of ingrediant (string vaiable)
    - Quantity (double variable)
    - Unit of measure of quantity
    - Food group (string variable)
    - Calories(double variable)
7. After all ingrediant details have been entered the user will be asked to enter each step of the recipe according to the number of steps that the user indicated at the beggining of the sytem run.
8. The system will then desplay the following menu for the user to choose from:
    1. Display at original Scale
    2. Display at double Scale
    3. Display at triple Scale
    4. Display at half Scale
    5. Exit
9. Additionally the application will continuasly check the number of calories at each scale (double, triple, half or original) and issue a high calory warning if the number of calories exceeds 300 calories.
9. The system will allow the user to enter different options until they decide that they are done with the recipe and want to exit the system or choose enter another recipe.


## If you want to make changes to project
This is an open project and therefore any one is free to download and rename the file and make any kind of changes that they desire. Users can change the project to suit their own needs and even make vital improvements to the project that can help the project to fuction better than it does now.

## If you find a bug
In case that you find a but please put in a a file detailing the bug and a probable solutin when you submit a pull request.

## Looking to the future
For part three of this project there will be the following changes and additional fuctionalities:
1. The system will now have a user interface implemented using Windows Picture Framework (WPF).
2. The system will use controls and styles to represent user various user controls in an appealing and easy to use style.
3. The application will have a filter fuction that will allow a user to search for the a recipe based on the following:
   * Ingredient
   * Food group
   * Max number of calories
4. This is only a glimps of changes and improvements that are coming and they will be seen properly in the actual implementation.
## Thank you for reading
I hope you enjoy using this project, Thank you.
## Github Repository Link
<a href="https://github.com/ST10375898/POE_PART2">Repository Link</a>
## Screeshot of Repository Commit
<img src="Screenshot (178).png" width="" height="500px">



