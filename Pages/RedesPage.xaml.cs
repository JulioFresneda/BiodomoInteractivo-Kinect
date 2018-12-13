//------------------------------------------------------------------------------
// <copyright file="RedesPage.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Resources;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Wpf.Controls;
    using Microsoft.Samples.Kinect.ControlsBasics.DataModel;
    using Microsoft.Samples.Kinect.ControlsBasics.Pages.ExploraSubPages;

    /// <summary>
    /// A sample showing a visualization of PointerPoints from Kinect
    /// </summary>
    public partial class RedesPage 
    {

        public RedesPage()
        {
            this.InitializeComponent();

            DrawAssets();

            





        }




        private void DrawAssets()
        {
            Uri uri = new Uri("Assets/redescabecera.png", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(uri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            this.cabeceraRedes.Source = temp;

            uri = new Uri("Assets/redesqr.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(uri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            this.codigosRedes.Source = temp;


            uri = new Uri("Assets/fbButton.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(uri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            this.fbButton.Background = brush;

            uri = new Uri("Assets/twButton.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(uri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.twButton.Background = brush;

            uri = new Uri("Assets/ytButton.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(uri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.ytButton.Background = brush;

            uri = new Uri("Assets/webButton.png", UriKind.Relative);
            streamInfo = Application.GetResourceStream(uri);

            temp = BitmapFrame.Create(streamInfo.Stream);
            brush = new ImageBrush();
            brush.ImageSource = temp;
            this.webButton.Background = brush;
        }

        private void ClickRedes(object sender, RoutedEventArgs e)
        {
            if( (sender as Button).Name == "fbButton")
            {
                System.Diagnostics.Process.Start("http://www.facebook.com/parqueciencias");
            }
            else if ((sender as Button).Name == "ytButton")
            {
                System.Diagnostics.Process.Start("http://www.youtube.com/parqueciencias");
            }
            else if ((sender as Button).Name == "twButton")
            {
                System.Diagnostics.Process.Start("http://www.twitter.com/ParqueCiencias");
            }
            else if ((sender as Button).Name == "webButton")
            {
                System.Diagnostics.Process.Start("http://www.biodomogranada.com");
            }
        }
    }
}
