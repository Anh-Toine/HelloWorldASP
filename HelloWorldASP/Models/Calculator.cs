using System;
using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class Calculator
    {
<<<<<<< HEAD
        /* Setters and Getters for the MealCost */

        // Error message in case user forgets to enter their cost of meal
        [Required(ErrorMessage = "Please enter the cost of your meal")]
        // Error message in case user enters an invalid value
        [Range(1,double.PositiveInfinity, ErrorMessage = "It must be a valid number greater than 0")]
        public decimal? MealCost { get; set; } // (*)
        // Method to deduce the tip based on the meal price 
        public decimal? CalculateTip(int percent) // (*)
        {
            decimal? tip;
            switch (percent)
            {
                case 15:
                    tip = MealCost * 15 / 100;
                    break;
                case 20:
                    tip = MealCost * 20 / 100;
                    break;
                case 25:
                    tip = MealCost * 25 / 100; 
                    break;
                default:
                    tip = 0.0M;
                    break;
            }
            return tip;
=======
        /* Setters and Getters for the Subtotal, and Discountpercent */

        // Error message in case user forgets to enter their subtotal
        [Required(ErrorMessage = "Please enter a subtotal")]
        // Error message in case user enters an invalid value
        [Range(1,double.PositiveInfinity, ErrorMessage = "Subtotal must be a valid number greater than 0")]
        public decimal? Subtotal { get; set; } // (*)

        // Error message in case user forgets to enter their discount percent
        [Required(ErrorMessage = "Please enter a discount percent")]
        // Error message in case user enters an invalid value
        [Range(0,100, ErrorMessage = "Discount percent must be a valid number from 0 to 100")]
        public int? DiscountPercent { get; set; } // (*)
     
        public decimal? DiscountAmountCalculate() // (*)
        {

            decimal? amount = Subtotal * DiscountPercent / 100; // (*)

            return amount;
        }

        public decimal? TotalCalculate() // (*)
        {
            decimal? total = Subtotal - DiscountAmountCalculate(); // (*)

            return total;
>>>>>>> 4122eda (First commit)
        }

    }
}

/*
 * (*): Nullable so as to enforce the constraints: Required & Range
 */