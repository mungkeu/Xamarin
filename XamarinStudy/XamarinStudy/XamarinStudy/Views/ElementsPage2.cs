using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinStudy.Views
{
    public class ElementsPage2 : ContentPage
    {
        public ElementsPage2()
        {
            Button btn = new Button() { Text = "배경색 변경", BackgroundColor = Color.BlueViolet, FontSize = 30 };
            btn.Clicked += (s, e) =>
             {
                 this.BackgroundColor = Color.DarkSlateGray;
             };
            Content = new StackLayout
            {
                Children =
                {
                    btn
                }
            };
        }
    }
}