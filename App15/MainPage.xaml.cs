using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App15
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {  
        public LinesViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new LinesViewModel();
            DataContext = ViewModel;

        }

        private void mapLoaded(object sender, RoutedEventArgs e)
        {  
            SetMapStyle();
            SetMapProjection();
        }


        private void styleCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Protect against events that are raised before we are fully initialized.
            if (map != null)
            {
                SetMapStyle();
            }
        }

        private void SetMapStyle()
        {
            switch (styleCombobox.SelectedIndex)
            {
                case 0:
                    map.Style = MapStyle.None;
                    break;
                case 1:
                    map.Style = MapStyle.Road;
                    break;
                case 2:
                    map.Style = MapStyle.Aerial;
                    break;
                case 3:
                    map.Style = MapStyle.AerialWithRoads;
                    break;
                case 4:
                    if (map.Is3DSupported)
                    {
                        map.Style = MapStyle.Aerial3DWithRoads;
                    }
                    else
                    {
                        map.Style = MapStyle.AerialWithRoads;
                    }
                    break;
                case 5:
                    map.Style = MapStyle.Terrain;
                    break;
            }
        }

        private void projectionCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Protect against events that are raised before we are fully initialized.
            if (map != null)
            {
                SetMapProjection();
            }
        }

        private void SetMapProjection()
        {
            switch (projectionCombobox.SelectedIndex)
            {
                case 0:
                    map.MapProjection = MapProjection.WebMercator;
                    break;
                case 1:
                    map.MapProjection = MapProjection.Globe;
                    break;
            }
        }       
    }
}


