//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
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
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class ExploraPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExploraPage"/> class. 
        /// </summary>
        public ExploraPage()
        {
            this.InitializeComponent();
            ExploraFrame.Content = new Amazonas();






        }

        private void AmazonasClick(object sender, RoutedEventArgs e)
        {
            ExploraFrame.Content = new Amazonas();
            
        }

        private void MadagascarClick(object sender, RoutedEventArgs e)
        {
            ExploraFrame.Content = new Madagascar();

        }

        private void IndopacificoClick(object sender, RoutedEventArgs e)
        {
            ExploraFrame.Content = new Indopacifico();

        }





    }
}
