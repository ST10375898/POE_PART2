using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_2_VERSION_2._0
{
    public class Ingredient
    {
        // declaration of properties of the ingredient object
        private string name;
        private double quantity;
        private string unit;
        private string foodGroup;
        private double calory;

        // declaring getters and setters of the properties

        public Ingredient(string name, double quantity, string unit, string foodGroup,double calories)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
            this.foodGroup = foodGroup;
            this.calory = calories;
        }
        
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string FoodGroup
        {
            get { return foodGroup; }
            set { foodGroup = value; }
        }
        public double Calory
        {
            get { return calory; }
            set { calory = value; }
        }
    }
}
