namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media.Imaging;
    using System.Windows.Resources;

    // Clase del mapa del biodomo, donde cargamos la imagen
    public partial class MapaPage : UserControl
    {
        
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
