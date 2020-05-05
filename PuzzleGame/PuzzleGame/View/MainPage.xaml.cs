using PuzzleGame.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuzzleGame
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.RotateYTo(360, 2000);
        }

       async void Button_Clicked(object o, EventArgs e)
        {
            await Navigation.PushModalAsync(new GamePage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.Red;
        }
    }
}
