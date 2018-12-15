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
	/// Interaction logic for Amazonia.xaml
	/// </summary>
	public partial class ZonePage : Page
	{
		private int puntero;
		List<int> indices;

		List<Uri> uriList;
		List<String> titleList;
		List<String> descList;

		private String currentZone;


		public ZonePage(List<Uri> _uriList, List<String> _titleList, List<String> _descList, String _currentZone)
		{
			InitializeComponent();
			puntero = 0;
			indices = new List<int>();
            
			uriList = _uriList;
			titleList = _titleList;
			descList = _descList;

			currentZone = _currentZone;

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

			StreamResourceInfo streamInfo = Application.GetResourceStream(uriList[indices[0]]);

			BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
			this.Especie.Source = temp;

			DrawButtons();
            
			this.Titulo.Text = titleList[indices[0]];
			this.Descripcion.Text = descList[indices[0]];
			Left.Visibility = Visibility.Hidden;
		}

        public void RightClick()
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
        
		public Uri GetCurrentImage()
		{
			return uriList[indices[puntero]];
		}

        
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
