using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegister
{
    public static class ChangeCalculate
    {
        public static string CalculateCh(decimal num, decimal paid)
        {
            string result = "";
            int hundreds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            decimal change = Convert.ToDecimal(paid - num);
            //change = Math.Round(change);

            while (change >= 100)
            {
                hundreds = hundreds + 1;
                change = change - 100;
            }
            while (change >= 50)
            {
                fifties = fifties + 1;
                change = change - 50;
            }
            while (change >= 20)
            {
                twenties = twenties + 1;
                change = change - 20;
            }
            while (change >= 10)
            {
                tens = tens + 1;
                change = change - 10;
            }
            while (change >= 5)
            {
                fives = fives + 1;
                change = change - 5;
            }
            while (change >= 1)
            {
                ones = ones + 1;
                change = change - 1;
            }
            while (change >= 0.25m)
            {
                quarters = quarters + 1;
                change = change - 0.25m;

            }
            while (change >= 0.10m)
            {
                dimes = dimes + 1;
                change = change - 0.10m;
            }
            while (change >= 0.05m)
            {
                nickels = nickels + 1;
                change = change - 0.05m;
            }
            while (change >= 0.01m)
            {
                pennies = pennies + 1;
                change = change - .01m;
            }
            //if keeping this while filter, could filter further to check for singlular numbers, but probably best to do a List sort of some sort
            result = $"Your change is {hundreds} hundreds, {fifties} fifties, {twenties} twenties, {tens} tens, {fives} fives, and {ones} ones \n The coin values are {quarters} quarters, {dimes} dimes, {nickels} nickels, and {pennies} pennies";
            //change this to a List with keys variable names, and values values
            return result;
            
             
        }
    }
}
