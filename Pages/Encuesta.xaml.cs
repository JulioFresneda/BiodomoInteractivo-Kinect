//------------------------------------------------------------------------------
// <copyright file="CheckBoxRadioButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Samples.Kinect.ControlsBasics.Pages;

    public partial class Encuesta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Encuesta"/> class. 
        /// </summary>
        /// 

        private List<Uri> uriFace;
        private ZonePage encuestaZone;

        public Encuesta()
        {
            this.InitializeComponent();
            this.LoadImages();
        }

        private void LoadImages()
        {
            uriFace = new List<Uri>
            {
                new Uri("Assets/smiley.png", UriKind.Relative),
                new Uri("Assets/sadly.png", UriKind.Relative)
            };
        }
    }
}
