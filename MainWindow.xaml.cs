//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

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



    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class. 
        /// </summary>
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

            //// Add in display content
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

        private void setCabecera()
        {
            Uri cabecera = new Uri("Assets/biodomoCabecera.png", UriKind.Relative);
            StreamResourceInfo streamInfoCab = Application.GetResourceStream(cabecera);

            BitmapFrame tempCab = BitmapFrame.Create(streamInfoCab.Stream);
            this.cabeceraBiodomo.Source = tempCab;
        }

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

        /// <summary>
        /// Handle a button click from the wrap panel.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
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

        /// <summary>
        /// Handle the back button click.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
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
