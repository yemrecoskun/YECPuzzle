﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuzzleGame.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Level6 : ContentPage
    {
        private Image img0x0 { get; set; }
        private Image img0x1 { get; set; }
        private Image img0x2 { get; set; }
        private Image img1x0 { get; set; }
        private Image img1x1 { get; set; }
        private Image img1x2 { get; set; }
        private Image img2x0 { get; set; }
        private Image img2x1 { get; set; }
        private Image img2x2 { get; set; }
        private Image img3x0 { get; set; }
        private Image img3x1 { get; set; }
        private Image img3x2 { get; set; }

        private string file0x0 = "level6_01.png";
        private string file0x1 = "level6_02.png";
        private string file0x2 = "level6_03.png";
        private string file1x0 = "level6_04.png";
        private string file1x1 = "level6_05.png";
        private string file1x2 = "level6_06.png";
        private string file2x0 = "level6_07.png";
        private string file2x1 = "level6_08.png";
        private string file2x2 = "level6_09.png";
        private string file3x0 = "level6_10.png";
        private string file3x1 = "level6_11.png";
        private string file3x2 = "level6_12.png";
        private string filenull = "imgnull5.png";

        [Obsolete]
        public Level6()
        {
            double width = .50, height = .50;
            InitializeComponent();
            img0x0 = new Image
            {
                Source = file0x0
            };
            img0x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x0));
            AbsoluteLayout.SetLayoutBounds(img0x0, new Rectangle(.15, .30, width, height));
            AbsoluteLayout.SetLayoutFlags(img0x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x0);

            img0x1 = new Image
            {
                Source = file0x1
            };
            img0x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x1));
            AbsoluteLayout.SetLayoutBounds(img0x1, new Rectangle(.4011, .30, width, height));
            AbsoluteLayout.SetLayoutFlags(img0x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x1);

            img0x2 = new Image
            {
                Source = file0x2
            };
            img0x2.GestureRecognizers.Add(new TapGestureRecognizer(imgTap0x2));
            AbsoluteLayout.SetLayoutBounds(img0x2, new Rectangle(.6559, .30, width, height));
            AbsoluteLayout.SetLayoutFlags(img0x2, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img0x2);


            img1x0 = new Image
            {
                Source = file1x0
            };
            img1x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x0));
            AbsoluteLayout.SetLayoutBounds(img1x0, new Rectangle(.15, .7, width, height));
            AbsoluteLayout.SetLayoutFlags(img1x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x0);

            img1x1 = new Image
            {
                Source = file1x1
            };
            img1x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x1));
            AbsoluteLayout.SetLayoutBounds(img1x1, new Rectangle(.4011, .7, width, height));
            AbsoluteLayout.SetLayoutFlags(img1x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x1);

            img1x2 = new Image
            {
                Source = file1x2
            };
            img1x2.GestureRecognizers.Add(new TapGestureRecognizer(imgTap1x2));
            AbsoluteLayout.SetLayoutBounds(img1x2, new Rectangle(.6559, .7, width, height));
            AbsoluteLayout.SetLayoutFlags(img1x2, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img1x2);

            img2x0 = new Image
            {
                Source = file2x0
            };
            img2x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap2x0));
            AbsoluteLayout.SetLayoutBounds(img2x0, new Rectangle(.15, 1, width, height));
            AbsoluteLayout.SetLayoutFlags(img2x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img2x0);

            img2x1 = new Image
            {
                Source = file2x1
            };
            img2x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap2x1));
            AbsoluteLayout.SetLayoutBounds(img2x1, new Rectangle(.4011, 1, width, height));
            AbsoluteLayout.SetLayoutFlags(img2x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img2x1);


            img2x2 = new Image
            {
                Source = file2x2
            };
            img2x2.GestureRecognizers.Add(new TapGestureRecognizer(imgTap2x2));
            AbsoluteLayout.SetLayoutBounds(img2x2, new Rectangle(.6559, 1, width, height));
            AbsoluteLayout.SetLayoutFlags(img2x2, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img2x2);

            img3x0 = new Image
            {
                Source = file3x0
            };
            img3x0.GestureRecognizers.Add(new TapGestureRecognizer(imgTap3x0));
            AbsoluteLayout.SetLayoutBounds(img3x0, new Rectangle(.15, 1.5, width, height));
            AbsoluteLayout.SetLayoutFlags(img3x0, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img3x0);

            img3x1 = new Image
            {
                Source = file3x1
            };
            img3x1.GestureRecognizers.Add(new TapGestureRecognizer(imgTap3x1));
            AbsoluteLayout.SetLayoutBounds(img3x1, new Rectangle(.4011, 1.5, width, height));
            AbsoluteLayout.SetLayoutFlags(img3x1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img3x1);

            img3x2 = new Image
            {
                Source = file3x2
            };
            img3x2.GestureRecognizers.Add(new TapGestureRecognizer(imgTap3x2));
            AbsoluteLayout.SetLayoutBounds(img3x2, new Rectangle(.6559, 1.5, width, height));
            AbsoluteLayout.SetLayoutFlags(img3x2, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(img3x2);
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
            var simg0x2 = img0x2.Source.ToString();
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
            else if (simg0x2 == "File: " + filenull)
            {
                img0x2.Source = img0x1.Source;
                img0x1.Source = filenull;
                imgControl();
            }
        }
        private void imgTap0x2(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x1 = img0x1.Source.ToString();
            var simg1x2 = img1x2.Source.ToString();
            if (simg0x1 == "File: " + filenull)
            {
                img0x1.Source = img0x2.Source;
                img0x2.Source = filenull;
                imgControl();
            }
            else if (simg1x2 == "File: " + filenull)
            {
                img1x2.Source = img0x2.Source;
                img0x2.Source = filenull;
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
            else if (simg2x0 == "File: " + filenull)
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
            var simg1x2 = img1x2.Source.ToString();
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
            else if (simg1x2 == "File: " + filenull)
            {
                img1x2.Source = img1x1.Source;
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

        private void imgTap1x2(Xamarin.Forms.View arg1, object arg2)
        {
            var simg0x2 = img0x2.Source.ToString();
            var simg1x1 = img1x1.Source.ToString();
            var simg2x2 = img2x2.Source.ToString();
            if (simg0x2 == "File: " + filenull)
            {
                img0x2.Source = img1x2.Source;
                img1x2.Source = filenull;
                imgControl();
            }
            else if (simg1x1 == "File: " + filenull)
            {
                img1x1.Source = img1x2.Source;
                img1x2.Source = filenull;
                imgControl();
            }
            else if (simg2x2 == "File: " + filenull)
            {
                img2x2.Source = img1x2.Source;
                img1x2.Source = filenull;
                imgControl();
            }
        }
        private void imgTap2x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg1x0 = img1x0.Source.ToString();
            var simg2x1 = img2x1.Source.ToString();
            var simg3x0 = img3x0.Source.ToString();
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
            else if (simg3x0 == "File: " + filenull)
            {
                img3x0.Source = img2x0.Source;
                img2x0.Source = filenull;
                imgControl();
            }
        }
        private void imgTap2x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg2x0 = img2x0.Source.ToString();
            var simg1x1 = img1x1.Source.ToString();
            var simg2x2 = img2x2.Source.ToString();
            var simg3x1 = img3x1.Source.ToString();
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
            else if (simg2x2 == "File: " + filenull)
            {
                img2x2.Source = img2x1.Source;
                img2x1.Source = filenull;
                imgControl();
            }
            else if (simg3x1 == "File: " + filenull)
            {
                img3x1.Source = img2x1.Source;
                img2x1.Source = filenull;
                imgControl();
            }
        }
        private void imgTap2x2(Xamarin.Forms.View arg1, object arg2)
        {
            var simg2x1 = img2x1.Source.ToString();
            var simg1x2 = img1x2.Source.ToString();
            var simg3x2 = img3x2.Source.ToString();
            if (simg2x1 == "File: " + filenull)
            {
                img2x1.Source = img2x2.Source;
                img2x2.Source = filenull;
                imgControl();
            }
            else if (simg1x2 == "File: " + filenull)
            {
                img1x2.Source = img2x2.Source;
                img2x2.Source = filenull;
                imgControl();
            }
            else if (simg3x2 == "File: " + filenull)
            {
                img3x2.Source = img2x2.Source;
                img2x2.Source = filenull;
                imgControl();
            }
        }
        private void imgTap3x0(Xamarin.Forms.View arg1, object arg2)
        {
            var simg2x0 = img2x0.Source.ToString();
            var simg3x1 = img3x1.Source.ToString();
            if (simg2x0 == "File: " + filenull)
            {
                img2x0.Source = img3x0.Source;
                img3x0.Source = filenull;
                imgControl();
            }
            else if (simg3x1 == "File: " + filenull)
            {
                img3x1.Source = img3x0.Source;
                img3x0.Source = filenull;
                imgControl();
            }
        }
        private void imgTap3x1(Xamarin.Forms.View arg1, object arg2)
        {
            var simg3x0 = img3x0.Source.ToString();
            var simg2x1 = img2x1.Source.ToString();
            var simg3x2 = img3x2.Source.ToString();
            if (simg3x0 == "File: " + filenull)
            {
                img3x0.Source = img3x1.Source;
                img3x1.Source = filenull;
                imgControl();
            }
            else if (simg2x1 == "File: " + filenull)
            {
                img2x1.Source = img3x1.Source;
                img3x1.Source = filenull;
                imgControl();
            }
            else if (simg3x2 == "File: " + filenull)
            {
                img3x2.Source = img3x1.Source;
                img3x1.Source = filenull;
                imgControl();
            }
        }
        private void imgTap3x2(Xamarin.Forms.View arg1, object arg2)
        {
            var simg2x2 = img2x2.Source.ToString();
            var simg3x1 = img3x1.Source.ToString();
            if (simg2x2 == "File: " + filenull)
            {
                img2x2.Source = img3x2.Source;
                img3x2.Source = filenull;
                imgControl();
            }
            else if (simg3x1 == "File: " + filenull)
            {
                img3x1.Source = img3x2.Source;
                img3x2.Source = filenull;
                imgControl();
            }
        }

        private void imgControl()
        {
            if (img0x0.Source.ToString() == "File: " + file0x0 &&
                img0x1.Source.ToString() == "File: " + file0x1 &&
                img0x2.Source.ToString() == "File: " + file0x2 &&
                img1x0.Source.ToString() == "File: " + file1x0 &&
                img1x1.Source.ToString() == "File: " + file1x1 &&
                img1x2.Source.ToString() == "File: " + file1x2 &&
                img2x0.Source.ToString() == "File: " + file2x0 &&
                img2x1.Source.ToString() == "File: " + file2x1 &&
                img2x2.Source.ToString() == "File: " + file2x2 &&
                img3x0.Source.ToString() == "File: " + file3x0 &&
                img3x1.Source.ToString() == "File: " + file3x1 &&
                img3x2.Source.ToString() == "File: " + filenull)
            {
                img3x2.Source = file3x2;
                DisplayAlert("Mission Completed", "Mission Completed", "OK");
            }
        }
    }
}