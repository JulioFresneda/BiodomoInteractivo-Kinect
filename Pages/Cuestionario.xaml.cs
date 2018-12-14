//------------------------------------------------------------------------------
// <copyright file="CheckBoxRadioButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Collections.Generic;

    public partial class Cuestionario
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cuestionario"/> class. 
        /// </summary>
        /// 

        private List<Uri> uriFace;

        public Cuestionario()
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
