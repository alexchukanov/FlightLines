using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        List<MapElement> featureList = null;

        int maxNumberLines = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }
        

        private async void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {

            if (map.MapElements.Count() != 0)
            {
                return;
            }
           

            if (!int.TryParse(tbMaxNumber.Text, out maxNumberLines))
            {
                tbMaxNumber.Text = "8000"; // max 88253 for TRA.geojson file
                maxNumberLines = 8000;
            }

            featureList = new List<MapElement>();

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".geojson");
                      

            StorageFile file = await openPicker.PickSingleFileAsync();

            prRing.IsActive = true;


            string text = await Windows.Storage.FileIO.ReadTextAsync(file);

            var responseStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(text);

            Feature [] featureArr = responseStatus.features;

            int i = 0;
                        

            foreach (var feature in featureArr)
            {
                var mapPolyline = new MapPolyline

                {
                    Path = new Geopath(new List<BasicGeoposition> {
                    new BasicGeoposition() {Latitude=feature.geometry.coordinates[0][1], Longitude=feature.geometry.coordinates[0][0]},
                    new BasicGeoposition() {Latitude=feature.geometry.coordinates[1][1], Longitude=feature.geometry.coordinates[1][0]},
                }),
                    StrokeColor = Colors.DarkBlue,
                    StrokeThickness = 1,
                    StrokeDashed = true,
                };
                                
                map.MapElements.Add(mapPolyline);


                if (i++ > maxNumberLines)
                {
                    break;
                }
            }
           
            prRing.IsActive = false;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            map.MapElements.Clear();
            GC.Collect();
        }
    }
}


