//------------------------------------------------------------------------------
// <copyright file="MapaViewer.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media.Imaging;
    using System.Windows.Resources;

    /// <summary>
    /// Interaction logic for MapaViewer
    /// </summary>
    public partial class MapaPage : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollViewerSample"/> class.
        /// </summary>
        public MapaPage()
        {
            this.InitializeComponent();

            Uri resourceUri = new Uri("Images/mapaBiodomo.jpg", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            zoomablephoto.Source = temp;
        }
    }
}
