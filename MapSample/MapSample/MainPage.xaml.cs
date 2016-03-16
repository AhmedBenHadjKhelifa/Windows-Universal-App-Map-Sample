using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MapSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = 36.9035697, Longitude = 10.1871828 };
            Geopoint snPoint = new Geopoint(snPosition);
            Display.Center = snPoint;


            // Create a MapIcon.
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/CustomMarker1.png"));
            Debug.WriteLine(mapIcon1.Image.ToString());
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Marker1";
            mapIcon1.ZIndex = 0;


            // Add the MapIcon to the map.
            Display.MapElements.Add(mapIcon1);

            snPosition = new BasicGeoposition() { Latitude = 36.8996732, Longitude = 10.1903711 };
            snPoint = new Geopoint(snPosition);

            // Create a MapIcon.
            mapIcon1 = new MapIcon();
            mapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/CustomMarker2.png"));
            Debug.WriteLine(mapIcon1.Image.ToString());
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Marker2";
            mapIcon1.ZIndex = 0;
            // Add the MapIcon to the map.
            Display.MapElements.Add(mapIcon1);


            // Add the MapIcon to the map.
            Display.MapElements.Add(mapIcon1);

            snPosition = new BasicGeoposition() { Latitude = 36.8980237, Longitude = 10.1930917 };
            snPoint = new Geopoint(snPosition);

            // Create a MapIcon.
            mapIcon1 = new MapIcon();
            mapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/CustomMarker3.png"));
            Debug.WriteLine(mapIcon1.Image.ToString());
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Marker3";
            mapIcon1.ZIndex = 0;
            
            // Add the MapIcon to the map.
            Display.MapElements.Add(mapIcon1);

            Display.ZoomLevel = 10;
        }
    }
}
