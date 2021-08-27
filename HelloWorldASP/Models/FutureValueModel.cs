﻿namespace FutureValue.Models
{
    public class FutureValueModel
    {
        // Setters and Getters for the MonthlyInvestment, YearlyInterestRate, and Years
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate =
            YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment)
                * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

    }
}