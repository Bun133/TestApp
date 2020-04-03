using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApp
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "This is HomePage!" },
                    new Button { Text = "Goto OptionPage", Clicked = GotoOptionPage }
                }
            };
        }

        void GotoOptionPage() {

        }
    }
}