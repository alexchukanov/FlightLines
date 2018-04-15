using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI;
using Windows.UI.Xaml.Controls.Maps;

namespace App15
{
    public class LinesViewModel : Observable
    {
        bool isWaiting = false;
        public bool IsWaiting
        {
            get
            {
                return isWaiting;
            }
            set
            {
                Set(ref isWaiting, value);
            }
        }

        public ObservableCollection<MapLayer> MapLinesLayer
        {
            get;
            set;
        } 

        Feature[] featureArr = null;
        int maxNumberLines = 8000;

        public LinesViewModel()
        {
            MapLinesLayer = new ObservableCollection<MapLayer>();
        }
               
        private async void LoadLines(object linesN)
        {
            IsWaiting = true;

            if (!int.TryParse((string)linesN, out maxNumberLines))
            {
                // max 88253 for TRA.geojson file
                maxNumberLines = 8000;
            }

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".geojson");
            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                string text = await Windows.Storage.FileIO.ReadTextAsync(file);

                var responseStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(text);

                featureArr = responseStatus.features;
            }

            int i = 0;

            var mapElementList = new List<MapElement>();

            foreach (var feature in featureArr)
            {
                MapElement mapPolyline = new MapPolyline

                {
                    Path = new Geopath(new List<BasicGeoposition> {
                    new BasicGeoposition() {Latitude=feature.geometry.coordinates[0][1], Longitude=feature.geometry.coordinates[0][0]},
                    new BasicGeoposition() {Latitude=feature.geometry.coordinates[1][1], Longitude=feature.geometry.coordinates[1][0]},
                }),
                    StrokeColor = Colors.DarkBlue,
                    StrokeThickness = 1,
                    StrokeDashed = true,
                };

                mapElementList.Add(mapPolyline);

                if (i++ > maxNumberLines)
                {
                    IsWaiting = false;
                    break;
                }
            }

            var LandmarksLayer = new MapElementsLayer
            {
                ZIndex = 1,
                MapElements = mapElementList
            };

            MapLinesLayer.Add(LandmarksLayer);

            IsWaiting = false;
        }

        private RelayCommand<string> loadLinesCommand;
        public RelayCommand <string> LoadLinesCommand
        {
            get
            {
                if (loadLinesCommand == null)
                {   
                   loadLinesCommand = new RelayCommand<string>(LoadLines);
                }

                return this.loadLinesCommand;
            }
            set
            {
                this.loadLinesCommand = value;
            }
        }
                
        private void ClearLines()
        {
           MapLinesLayer.Clear();           
        }


        private RelayCommand clearLinesCommand;
        public RelayCommand ClearLinesCommand
        {
            get
            {
                if (clearLinesCommand == null)
                {
                    clearLinesCommand = new RelayCommand(ClearLines);
                }

                return this.clearLinesCommand;
            }
            set
            {
                this.clearLinesCommand = value;
            }
        }

        private void HideLines()
        {
            
            int layerN = MapLinesLayer.Count();

            if (layerN > 0)
            {
                MapLinesLayer[layerN - 1].Visible = !MapLinesLayer[layerN - 1].Visible;
            }
        }

        private RelayCommand hideLinesCommand;
        public RelayCommand HideLinesCommand
        {
            get
            {
                if (hideLinesCommand == null)
                {
                    hideLinesCommand = new RelayCommand(HideLines);
                }

                return this.hideLinesCommand;
            }
            set
            {
                this.hideLinesCommand = value;
            }
        }
    }
}
