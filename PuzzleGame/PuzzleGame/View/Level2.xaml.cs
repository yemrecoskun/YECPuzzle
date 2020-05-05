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
    public partial class Level2 : ContentPage
    {
        private Image img0x0 { get; set; }
        private Image img0x1 { get; set; }
        private Image img1x0 { get; set; }
        private Image img1x1 { get; set; }
        private Image img2x0 { get; set; }
        private Image img2x1 { get; set; }
        private string file0x0 = "level20x0.png";
        private string file0x1 = "level20x1.png";
        private string file1x0 = "level21x0.png";
        private string file1x1 = "level21x1.png";
        private string file2x0 = "level22x0.png";
        private string file2x1 = "level22x1.png";
        private string filenull = "imgnull.png";

        [Obsolete]
        public Level2()
        {
            InitializeComponent();
            img0x0 = new Image
            {
                Source = file2x0
            };
            img0x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x0));
            AbsoluteLayout.SetLayoutBounds(img0x0, new Rectangle(.255, 0, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img0x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x0);
            img0x1 = new Image
            {
                Source = file1x1
            };
            img0x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x1));
            AbsoluteLayout.SetLayoutBounds(img0x1, new Rectangle(.75, 0, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img0x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x1);
            img1x0 = new Image
            {
                Source = filenull
            };
            img1x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x0));
            AbsoluteLayout.SetLayoutBounds(img1x0, new Rectangle(.255, .39, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img1x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x0);
            img1x1 = new Image
            {
                Source = file0x0
            };
            img1x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x1));
            AbsoluteLayout.SetLayoutBounds(img1x1, new Rectangle(.75, .39, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img1x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x1);
            img2x0 = new Image
            {
                Source = file0x1
            };
            img2x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap2x0));
            AbsoluteLayout.SetLayoutBounds(img2x0, new Rectangle(.255, .78, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img2x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img2x0);
            img2x1 = new Image
            {
                Source = file1x0
            };
            img2x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap2x1));
            AbsoluteLayout.SetLayoutBounds(img2x1, new Rectangle(.75, .78, .33, .33));
            AbsoluteLayout.SetLayoutFlags(img2x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img2x1);
        }

        

        private void imgTap0x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x1 = img0x1.Source.ToString();
            var simg1x0 = img1x0.Source.ToString();
            if (simg0x1 == "File: " + filenull)
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
            var simg2x0 = img2x0.Source.ToString();
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
            else if(simg2x0 =="File: " + filenull)
            {
                img2x0.Source = img1x0.Source;
                img1x0.Source = filenull;
                imgControl();
            }
        }

        private void imgTap1x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x1 = img0x1.Source.ToString();
            var simg1x0 = img1x0.Source.ToString();
            var simg2x1 = img2x1.Source.ToString();
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
            else if (simg2x1 == "File: " + filenull)
            {
                img2x1.Source = img1x1.Source;
                img1x1.Source = filenull;
                imgControl();
            }
        }
        private void imgTap2x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg1x0 = img1x0.Source.ToString();
            var simg2x1 = img2x1.Source.ToString();
            if (simg1x0 == "File: " + filenull)
            {
                img1x0.Source = img2x0.Source;
                img2x0.Source = filenull;
                imgControl();
            }
            else if (simg2x1 == "File: " + filenull)
            {
                img2x1.Source = img2x0.Source;
                img2x0.Source = filenull;
                imgControl();
            }
        }
        private void imgTap2x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg2x0 = img2x0.Source.ToString();
            var simg1x1 = img1x1.Source.ToString();
            if (simg2x0 == "File: " + filenull)
            {
                img2x0.Source = img2x1.Source;
                img2x1.Source = filenull;
                imgControl();
            }
            else if (simg1x1 == "File: " + filenull)
            {
                img1x1.Source = img2x1.Source;
                img2x1.Source = filenull;
                imgControl();
            }
        }
        private void imgControl()
        {
            if (img0x0.Source.ToString() == "File: " + file0x0 &&
                img0x1.Source.ToString() == "File: " + file0x1 &&
                img1x0.Source.ToString() == "File: " + file1x0 &&
                img1x1.Source.ToString() == "File: " + file1x1 &&
                img2x0.Source.ToString() == "File: " + file2x0 &&
                img2x1.Source.ToString() == "File: " + filenull )
            {
                img2x1.Source = file2x1;
                DisplayAlert("Mission Completed", "Mission Completed", "OK");

            }
        }
    }
}