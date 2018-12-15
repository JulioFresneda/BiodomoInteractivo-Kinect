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



    // Clase principal de la aplicación
    public partial class MainWindow
    {
        
        public MainWindow()
        {
            this.InitializeComponent();

            kinectRegion.Loaded += (args, e) =>
            {
                App app = ((App)Application.Current);
                app.KinectRegion = kinectRegion;
                KinectRegion.SetKinectRegion(this, kinectRegion);
                this.kinectRegion.KinectSensor = KinectSensor.GetDefault();

                //gestureDetector = new GestureDetector(this.kinectRegion.KinectSensor);

                //gestureDetector.GestoDetectado += (s, argss) =>
                //{
                //    this.detectedText.Text = "Gesto detectada";
                //};

                //gestureDetector.GestoNoDetectado += (s, argss) =>
                //{
                //    this.detectedText.Text = "Gesto no detectada";
                //};
            };

            kinectRegion.KinectSensor.IsAvailableChanged += (s, e) =>
            {
                //Set status kinect
                this.statusKinectText.Text = kinectRegion.KinectSensor.IsAvailable ? Properties.Resources.SiKinectStatusText
                                                            : Properties.Resources.NoKinectStatusText;

            };

            //// Obtenemos el contenido de cada botón
            var sampleDataSource = DataModel.DataModel.GetGroup("Group-1");

            // set cabecera main windows
            setCabecera();

            // Set the main buttons of Biodomo
            SetMainButtons(sampleDataSource);

            // Set minimize button in main window
            SetMinimiceButton();

            // Set exit button in main window
            SetExitButton();

        }


        // Obtenemos la imagen de la cabecera y se la asignamos
        private void setCabecera()
        {
            Uri cabecera = new Uri("Assets/biodomoCabecera.png", UriKind.Relative);
            StreamResourceInfo streamInfoCab = Application.GetResourceStream(cabecera);

            BitmapFrame tempCab = BitmapFrame.Create(streamInfoCab.Stream);
            this.cabeceraBiodomo.Source = tempCab;
        }


        // Obtenemos las imágenes de cada uno de los cuatro botones y se las asignamos
        private void SetMainButtons(DataCollection sampleDataSource)
        {
            if (sampleDataSource == null)
            {
                throw new ArgumentNullException(nameof(sampleDataSource));
            }

            foreach (DataItem button in sampleDataSource)
            {
                if (button.Title == "Explora")
                {
                    Uri resourceUri = new Uri("Assets/exploraButton.png", UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;

                    this.exploraButton.DataContext = button;
                    this.exploraButton.Background = brush;
                }
                else if (button.Title == "Encuesta")
                {
                    Uri resourceUri = new Uri("Assets/encuestaButton.png", UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;

                    this.encuestaButton.DataContext = button;
                    this.encuestaButton.Background = brush;
                }
                else if (button.Title == "Mapa")
                {
                    Uri resourceUri = new Uri("Assets/mapaButton.png", UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;

                    this.mapaButton.DataContext = button;
                    this.mapaButton.Background = brush;
                }
                else if (button.Title == "Redes Sociales")
                {
                    Uri resourceUri = new Uri("Assets/redesButton.png", UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;

                    this.redesButton.DataContext = button;
                    this.redesButton.Background = brush;
                }

            }
        }


        // Obtenemos las imágenes de salir y minimizar y se las asignamos a los botones
        private void SetMinimiceButton()
        {
            Uri minimizeButton = new Uri("Assets/minimize_button.png", UriKind.Relative);
            StreamResourceInfo streamInfoEB = Application.GetResourceStream(minimizeButton);

            BitmapFrame tempEB = BitmapFrame.Create(streamInfoEB.Stream);
            var brushEB = new ImageBrush();
            brushEB.ImageSource = tempEB;
            this.minimizeButton.Background = brushEB;
        }

        private void SetExitButton()
        {
            Uri exitButton = new Uri("Assets/exit_button.png", UriKind.Relative);
            StreamResourceInfo streamInfoEB = Application.GetResourceStream(exitButton);

            BitmapFrame tempEB = BitmapFrame.Create(streamInfoEB.Stream);
            var brushEB = new ImageBrush();
            brushEB.ImageSource = tempEB;
            this.exitButton.Background = brushEB;
        }

        // Acción al clickar sobre un botón
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.OriginalSource;
            DataItem sampleDataItem = button.DataContext as DataItem;

            if (sampleDataItem != null && sampleDataItem.NavigationPage != null)
            {
                backButton.Visibility = System.Windows.Visibility.Visible;
                navigationRegion.Content = Activator.CreateInstance(sampleDataItem.NavigationPage);
            }
            else
            {
                var selectionDisplay = new SelectionDisplay(button.Content as string);
                this.kinectRegionGrid.Children.Add(selectionDisplay);

                // Selection dialog covers the entire interact-able area, so the current press interaction
                // should be completed. Otherwise hover capture will allow the button to be clicked again within
                // the same interaction (even whilst no longer visible).
                selectionDisplay.Focus();

                // Since the selection dialog covers the entire interact-able area, we should also complete
                // the current interaction of all other pointers.  This prevents other users interacting with elements
                // that are no longer visible.
                this.kinectRegion.InputPointerManager.CompleteGestures();

                e.Handled = true;


            }
        }

        // Ir hacia atrás
        private void GoBack(object sender, RoutedEventArgs e)
        {
            backButton.Visibility = System.Windows.Visibility.Hidden;
            navigationRegion.Content = this.kinectRegionGrid;
        }
        
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
