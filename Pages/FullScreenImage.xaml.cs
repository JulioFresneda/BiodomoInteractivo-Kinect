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

namespace Microsoft.Samples.Kinect.ControlsBasics.Pages
{
    /// <summary>
    /// Interaction logic for FullScreenImage.xaml
    /// </summary>
    public partial class FullScreenImage : Page
    {
        public FullScreenImage( Uri imageUri )
        {
            InitializeComponent();

            
            StreamResourceInfo streamInfo = Application.GetResourceStream(imageUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            

            this.image.Source = temp;
        }
    }
}
