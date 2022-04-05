using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CashRegister
{
    public class MainPage : ContentPage
        {
        Entry totalAmount;
        Button makeChange;
        Entry totalChange;

        public MainPage()
        {
            StackLayout panel = new StackLayout();
            panel.Orientation = StackOrientation.Vertical;

            panel.Children.Add(new Label
            {
                Text = "Enter a total amount: "
            });

            panel.Children.Add(totalAmount = new Entry
            {

            });

            panel.Children.Add(makeChange = new Button
            {
                Text = "Calculate Change"
            });

            panel.Children.Add(totalChange = new Entry
            {

            });
            this.Content = panel;
        }
    }
}
