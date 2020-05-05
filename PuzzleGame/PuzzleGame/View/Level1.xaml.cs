using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuzzleGame.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {

        private Image img0x0 { get; set; }
        private Image img0x1 { get; set; }
        private Image img1x0 { get; set; }
        private Image img1x1 { get; set; }
        private string file0x0 = "logo0x0.png";
        private string file0x1 = "logo0x1.png";
        private string file1x0 = "logo1x0.png";
        private string file1x1 = "logo1x1.png";
        private string filenull = "imgnull.png";
        [Obsolete]
        public GamePage()
        {
            InitializeComponent();
            OriginalImg.Source = "logo.png";
            img0x0 = new Image
            {
                Source = "logo1x0.png",
            };
            img0x0.GestureRecognizers.Add (new TapGestureRecognizer (imgTap0x0));
            AbsoluteLayout.SetLayoutBounds(img0x0, new Rectangle(0, 0, .5, .5));
            AbsoluteLayout.SetLayoutFlags(img0x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x0);
            img0x1 = new Image
            {
                Source = "logo0x0.png"
            };
            img0x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x1));
            AbsoluteLayout.SetLayoutBounds(img0x1, new Rectangle(1, 0, .5, .5));
            AbsoluteLayout.SetLayoutFlags(img0x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x1);

            img1x0 = new Image
            {
                Source = "imgnull.png"
            };
            img1x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x0));
            AbsoluteLayout.SetLayoutBounds(img1x0, new Rectangle(0, .71, .5, .5));
            AbsoluteLayout.SetLayoutFlags(img1x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x0);

            img1x1 = new Image
            {
                Source = "logo0x1.png"
            };
            img1x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x1));
            AbsoluteLayout.SetLayoutBounds(img1x1, new Rectangle(1, .71, .5, .5));
            AbsoluteLayout.SetLayoutFlags(img1x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x1);
        }

        private void imgTap0x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x1 =img0x1.Source.ToString();
            var simg1x0 = img1x0.Source.ToString();
            if (simg0x1 == "File: "+filenull)
            {
                img0x1.Source = img0x0.Source;
                img0x0.Source = filenull;
                imgControl();
            }
            else if (simg1x0 == "File: " + filenull)
            {
                img1x0.Source = img0x0.Source;
                img0x0.Source = filenull;
                imgControl();
            }
        }
        private void imgTap0x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x0 = img0x0.Source.ToString();
            var simg1x1 = img1x1.Source.ToString();
            if (simg0x0 == "File: " + filenull)
            {
                img0x0.Source = img0x1.Source;
                img0x1.Source = filenull;
                imgControl();
            }
            else if (simg1x1 == "File: " + filenull)
            {
                img1x1.Source = img0x1.Source;
                img0x1.Source = filenull;
                imgControl();
            }
        }

        private void imgTap1x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x0 = img0x0.Source.ToString();
            var simg1x1 = img1x1.Source.ToString();
            if (simg0x0 == "File: " + filenull)
            {
                img0x0.Source = img1x0.Source;
                img1x0.Source = filenull;
                imgControl();
            }
            else if (simg1x1 == "File: " + filenull)
            {
                img1x1.Source = img1x0.Source;
                img1x0.Source = filenull;
                imgControl();
            }
        }

        private void imgTap1x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x1 = img0x1.Source.ToString();
            var simg1x0 = img1x0.Source.ToString();
            if (simg0x1 == "File: " + filenull)
            {
                img0x1.Source = img1x1.Source;
                img1x1.Source = filenull;
                imgControl();
            }
            else if (simg1x0 == "File: " + filenull)
            {
                img1x0.Source = img1x1.Source;
                img1x1.Source = filenull;
                imgControl();
            }
        }
        private void imgControl()
        {
            if( img0x0.Source.ToString() == "File: " + file0x0 &&
                img0x1.Source.ToString() == "File: " + file0x1 && 
                img1x0.Source.ToString() == "File: " + file1x0 && 
                img1x1.Source.ToString() == "File: " + filenull)
            {
                img1x1.Source = file1x1;
                DisplayAlert("Mission Completed", "Mission Completed", "OK");
                Navigation.PushModalAsync(new Level2());

            }
        }
    }
}