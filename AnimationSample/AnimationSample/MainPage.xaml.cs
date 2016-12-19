using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;

namespace AnimationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("AnimationSample.test2.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            image.ScaleTo(1, 0, null);
            image.RotateTo(0, 0, null);
            image.RotateXTo(0, 0, null);
            image.RotateYTo(0, 0, null);
            image.TranslateTo(0, 0, 0, null);
            image.FadeTo(100, 0, null);
            //var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            //foreach (var res in assembly.GetManifestResourceNames())
            //{
            //    System.Diagnostics.Debug.WriteLine("found resource: " + res);
            //}
        }

        private void ScaleTo_Clicked(object sender, EventArgs e)
        {
            image.ScaleTo(1.5, 250, null );
        }

        private void RelScaleTo_Clicked(object sender, EventArgs e)
        {
            image.RelScaleTo(1.5, 250, null);
        }

        private void RotateTo_Clicked(object sender, EventArgs e)
        {
            image.RotateTo(45, 250, null);
        }

        private void RelRotateTo_Clicked(object sender, EventArgs e)
        {
            image.RelRotateTo(45, 250, null);
        }

        private void RotateXTo_Clicked(object sender, EventArgs e)
        {
            image.RotateXTo(45, 250, null);
        }

        private void RotateYTo_Clicked(object sender, EventArgs e)
        {
            image.RotateYTo(45, 250, null);
        }

        private void TranslateTo_Clicked(object sender, EventArgs e)
        {
            image.TranslateTo(100, 100, 250, null);
        }

        private void FadeTo_Clicked(object sender, EventArgs e)
        {
            image.FadeTo(0, 250, null);
        }
    }
}
