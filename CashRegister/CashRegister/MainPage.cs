using System;
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
            BackgroundColor = Color.SlateBlue;

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
            
            makeChange.Clicked += OnCalc; //calls OnCalc function when clicked, which outputs to the finalChange panel
            this.Content = panel;
        }
        private void OnCalc(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(price.Text); //from panel.Children.Add(price
            decimal paiddouble = Convert.ToDecimal(paid.Text); //panel.Children.Add(paid
            totalChange = CashRegister.ChangeCalculate.CalculateCh(amount, paiddouble); //variable assigned to name of project,classname,functionname(passeditems)

            if (!string.IsNullOrEmpty(totalChange))
            {
                finalChange.Text = totalChange.ToString();
            }
        }
    }
}
