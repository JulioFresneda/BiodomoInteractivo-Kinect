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

namespace Microsoft.Samples.Kinect.ControlsBasics.Pages.ExploraSubPages
{
    /// <summary>
    /// Interaction logic for Indopacifico.xaml
    /// </summary>
    public partial class Indopacifico : Page
    {
        private List<Uri> uriIndopacifico;
        int puntero;

        public Indopacifico()
        {
            InitializeComponent();
            uriIndopacifico = new List<Uri>();

            LoadSpecies(uriIndopacifico);
            puntero = 0;

            Uri resourceUri = new Uri("Assets/ama_a_0.png", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            this.Especie.Source = temp;

        }





        public void LoadSpecies(List<Uri> uriIndopacifico)
        {

            // imagenes amazonas
            uriIndopacifico.Add(new Uri("Assets/ama_a_0.png", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_1.jpeg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_2.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_3.jpeg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_4.jpeg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_5.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_6.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_7.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_8.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_9.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_10.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_11.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_12.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_13.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_14.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_15.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_16.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_a_17.jpg", UriKind.Relative));


            uriIndopacifico.Add(new Uri("Assets/ama_v_0.png", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_1.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_2.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_3.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_4.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_5.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_6.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_7.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_8.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_9.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_10.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_11.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_12.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_13.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_14.jpg", UriKind.Relative));
            uriIndopacifico.Add(new Uri("Assets/ama_v_15.jpg", UriKind.Relative));


        }

        private void RightClick(object sender, RoutedEventArgs e)
        {
            if (puntero < uriIndopacifico.Count - 1)
            {
                puntero++;
                Uri resourceUri = uriIndopacifico[puntero];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;
            }

        }

        private void LeftClick(object sender, RoutedEventArgs e)
        {
            if (puntero > 0)
            {
                puntero--;
                Uri resourceUri = uriIndopacifico[puntero];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;
            }

        }
    }
}
