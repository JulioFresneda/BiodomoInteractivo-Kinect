//------------------------------------------------------------------------------
// <copyright file="CheckBoxRadioButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Resources;
    using System.Windows.Shapes;

    public partial class Encuesta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Encuesta"/> class. 
        /// </summary>
        /// 

        private Uri uriFace;
        private bool smiley = true;

        // FALTA SABER COMO SE RECONOCEN LOS GESTOS PARA ASÍ PODER CAMBIAR ENTRE CARAS

        public Encuesta()
        {
            this.InitializeComponent();
            this.PrintImages();
        }

        private void PrintImages()
        {
            if (smiley == true)
            {
                uriFace = new Uri("Assets/smiley.png", UriKind.Relative);
            }
            else
            {
                uriFace = new Uri("Assets/sadly.png", UriKind.Relative);
            }

            StreamResourceInfo streamInfo = Application.GetResourceStream(uriFace);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);

            this.Face.Source = temp;

        }
    }
}
