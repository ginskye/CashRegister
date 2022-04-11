﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CashRegister
{
    public class MainPage : ContentPage
        {
        Entry price;
        Entry paid;
        Button makeChange;
        string totalChange;
        Editor finalChange;

        public MainPage()
        {
            StackLayout panel = new StackLayout();
            panel.Orientation = StackOrientation.Vertical;
            BackgroundColor = Color.GreenYellow;

            panel.Children.Add(new Label
            {
                Text = "Enter the price for item purchased: "
            });

            panel.Children.Add(price = new Entry
            {

            });

            panel.Children.Add(new Label
            {
                Text = "Enter the amount paid: "
            });

            panel.Children.Add(paid = new Entry
            {

            });

            panel.Children.Add(makeChange = new Button
            {
                Text = "Calculate Change"
            });

            panel.Children.Add(finalChange = new Editor
            {
                AutoSize = EditorAutoSizeOption.TextChanges
            }) ;
            
            makeChange.Clicked += OnCalc;
            this.Content = panel;
        }
        private void OnCalc(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(price.Text);
            decimal paiddouble = Convert.ToDecimal(paid.Text);
            totalChange = CashRegister.ChangeCalculate.CalculateCh(amount, paiddouble);

            if (!string.IsNullOrEmpty(totalChange))
            {
                finalChange.Text = totalChange.ToString();
            }
        }
    }
}
