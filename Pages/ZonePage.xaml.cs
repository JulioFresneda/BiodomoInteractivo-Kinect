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
	// Clase que contiene el visor de imágenes de cada zona. 
    // Esta clase contiene la información de UNA ÚNICA zona, así como los botones de derecha e izquierda.
	public partial class ZonePage : Page
	{

        // Puntero el cual nos dice en qué posición estamos
		private int puntero;

        // Lista de índices, la usaremos para mostrar las especies de forma desordenada
		List<int> indices;

        // Listas con las Uri de imágenes, los títulos y las descripciones de las especies de la zona en concreto
		List<Uri> uriList;
		List<String> titleList;
		List<String> descList;

        // Contiene el nombre de la zona actual
		private String currentZone;


        // Para crear un ZonePage, se necesita una lista de direcciones de imágenes, otra de títulos y otra de descripciones,
        // así como el nombre de la zona actual
		public ZonePage(List<Uri> _uriList, List<String> _titleList, List<String> _descList, String _currentZone)
		{
			InitializeComponent();

            //Inicializamos variables
			puntero = 0;
			indices = new List<int>();
            
			uriList = _uriList;
			titleList = _titleList;
			descList = _descList;

			currentZone = _currentZone;

            // Llenamos nuestra lista de índices con números entre 0 y nº especies -1, ordenados aleatoriamente
			Random r = new Random();
			List<int> indicestemp = new List<int>();
            
			for (int i = 0; i < uriList.Count; i++)
			{
				indicestemp.Add(i);
			}
			while (indicestemp.Count > 0)
			{
				int rand = r.Next(0, indicestemp.Count);
				indices.Add(indicestemp[rand]);
				indicestemp.RemoveAt(rand);
			}


            // Cargamos la imagen, título y descripción de la primera especie
			StreamResourceInfo streamInfo = Application.GetResourceStream(uriList[indices[0]]);

			BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
			this.Especie.Source = temp;

            this.Titulo.Text = titleList[indices[0]];
            this.Descripcion.Text = descList[indices[0]];
            Left.Visibility = Visibility.Hidden; // Al ser la primera especie, desactivamos el botón de ir a la izquierda

            // Dibujamos los botones
            DrawButtons();
            
			
		}

        // Pasamos hacia el siguiente animal
        public void RightClick()
        {
            if (puntero < uriList.Count - 1)
            {
                // El botón de pasar a la izquierda ahora es visible
                if( puntero == 0 ) Left.Visibility = Visibility.Visible;
                puntero++;

                // Cargamos imagen, título y descripción de la siguiente especie
                Uri resourceUri = uriList[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titleList[indices[puntero]];
                this.Descripcion.Text = descList[indices[puntero]];

                // Si estamos en la última especie, hacemos el botón de siguiente invisible
                if (puntero == uriList.Count - 1)
                {
                    Right.Visibility = Visibility.Hidden;
                }
            }
        }

        // Sobrecargamos el método para usar gestos
        private void RightClick(object sender, RoutedEventArgs e)
		{
			if (puntero < uriList.Count - 1)
			{
				Left.Visibility = Visibility.Visible;
				puntero++;
				Uri resourceUri = uriList[indices[puntero]];
				StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

				BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
				this.Especie.Source = temp;

				this.Titulo.Text = titleList[indices[puntero]];
				this.Descripcion.Text = descList[indices[puntero]];

				if (puntero == uriList.Count - 1)
				{
					Right.Visibility = Visibility.Hidden;
				}
			}
		}


        // Igual que el RightClick, pero a la izquierda (especie anterior)
        public void LeftClick()
        {
            if (puntero > 0)
            {
                Right.Visibility = Visibility.Visible;
                puntero--;
                Uri resourceUri = uriList[indices[puntero]];
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                this.Especie.Source = temp;

                this.Titulo.Text = titleList[indices[puntero]];
                this.Descripcion.Text = descList[indices[puntero]];

                if (puntero == 0)
                {
                    Left.Visibility = Visibility.Hidden;
                }
            }

        }

        // Sobrecargamos el método para usar gestos
        private void LeftClick(object sender, RoutedEventArgs e)
		{
			if (puntero > 0)
			{
				Right.Visibility = Visibility.Visible;
				puntero--;
				Uri resourceUri = uriList[indices[puntero]];
				StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

				BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
				this.Especie.Source = temp;

				this.Titulo.Text = titleList[indices[puntero]];
				this.Descripcion.Text = descList[indices[puntero]];

				if (puntero == 0)
				{
					Left.Visibility = Visibility.Hidden;
				}
			}

		}
        

        // Obtenemos la Uri de la imagen de la especie actual
		public Uri GetCurrentImage()
		{
			return uriList[indices[puntero]];
		}

        // Dibujamos los botones de izquierda y derecha, así como el color del background del título
		private void DrawButtons()
		{
			Uri leftButtonUri = new Uri("Assets/explora_button_left_ama.png", UriKind.Relative);
			Uri rightButtonUri = new Uri("Assets/explora_button_right_ama.png", UriKind.Relative);
            
			if (currentZone == "amazonia")
			{
				this.Titulo.Background = new SolidColorBrush(Color.FromArgb(0xff, 0xff, 0xd3, 0x00));
				leftButtonUri = new Uri("Assets/explora_button_left_ama.png", UriKind.Relative);
				rightButtonUri = new Uri("Assets/explora_button_right_ama.png", UriKind.Relative);
			}
			if (currentZone == "madagascar")
			{
				this.Titulo.Background = new SolidColorBrush(Color.FromArgb(0xff, 0xc2, 0x00, 0x17));
				leftButtonUri = new Uri("Assets/explora_button_left_mad.png", UriKind.Relative);
				rightButtonUri = new Uri("Assets/explora_button_right_mad.png", UriKind.Relative);
			}
			if (currentZone == "indopacifico")
			{
				this.Titulo.Background = new SolidColorBrush(Color.FromArgb(0xff, 0x00, 0xd1, 0xb6));
				leftButtonUri = new Uri("Assets/explora_button_left_ip.png", UriKind.Relative);
				rightButtonUri = new Uri("Assets/explora_button_right_ip.png", UriKind.Relative);

			}
            
			StreamResourceInfo streamInfo = Application.GetResourceStream(leftButtonUri);

			BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
			var brush = new ImageBrush();
			brush.ImageSource = temp;
			this.Left.Background = brush;
			streamInfo = Application.GetResourceStream(rightButtonUri);

			temp = BitmapFrame.Create(streamInfo.Stream);
			brush = new ImageBrush();
			brush.ImageSource = temp;
			this.Right.Background = brush;
		}
	}
}
