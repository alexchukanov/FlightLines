﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI;
using Windows.UI.Core;
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

        string message = "";
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                Set(ref message, value);
            }
        }

        public ObservableCollection<MapLayer> MapLinesLayer
        {
            get;
            set;            
        }      

        Feature[] featureArr = null;
        int moreNumberLines = 4000;
        int totalNumberLines = 0;

        List<string> featureIdList = null;

        public LinesViewModel()
        {
           MapLinesLayer = new ObservableCollection<MapLayer>();
           featureIdList = new List<string>(moreNumberLines * 4);
        }
               
        private async void LoadLines(object linesN)
        {
            int.TryParse((string)linesN, out moreNumberLines);

            if (totalNumberLines == 0)
            {
                FileOpenPicker openPicker = new FileOpenPicker();
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                openPicker.FileTypeFilter.Add(".geojson");

                StorageFile file = await openPicker.PickSingleFileAsync();

                if (file != null)
                {
                    IsWaiting = true;

                    string text = await Windows.Storage.FileIO.ReadTextAsync(file);

                    if (featureArr == null)
                    {
                        try
                        {
                            var responseStatus = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(text);
                            featureArr = responseStatus.features;
                        }
                        catch
                        {
                            Message = "Select TRA file!";
                        }                        
                    }
                }
            }

            if (featureArr != null)
            { 
                int i = 0;

                var mapElementList = new List<MapElement>();

                foreach (var feature in featureArr)
                {
                        if (featureIdList.Contains(feature.properties.id))
                        {
                            continue;
                        }
                        else
                        {
                            featureIdList.Add(feature.properties.id);
                        }

                        MapElement mapPolyline = new MapPolyline
                        {
                            Path = new Geopath(new List<BasicGeoposition>
                        {
                            new BasicGeoposition() {Latitude=feature.geometry.coordinates[0][1], Longitude=feature.geometry.coordinates[0][0]},
                            new BasicGeoposition() {Latitude=feature.geometry.coordinates[1][1], Longitude=feature.geometry.coordinates[1][0]},
                        }),

                            StrokeColor = Colors.DarkBlue,
                            StrokeThickness = 1.5,
                            StrokeDashed = true,
                        };

                        mapElementList.Add(mapPolyline);

                        totalNumberLines++;

                        if (i++ >= moreNumberLines - 1)
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

                Message = $"Shown lines N = {totalNumberLines}";
            }

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
            totalNumberLines = 0;
            featureIdList.Clear();
            MapLinesLayer.Clear();
            GC.Collect();
                       
            Message = $"Shown lines N = {totalNumberLines}";
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
    }
}
