using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using System.Diagnostics;

using Xamarin.Forms;

namespace GeolocationTest.Pages
{
	public partial class GeolocatorPage : ContentPage
	{
		public GeolocatorPage ()
		{
			InitializeComponent ();
			buttonGetGPS.Clicked += async (sender, args) => {
				var watch = Stopwatch.StartNew();
				try {
					
					var locator = CrossGeolocator.Current;
					locator.DesiredAccuracy = 50;
					labelGPS.Text="Getting GPS";

					var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

					if(position==null)
					{
						labelGPS.Text="null GPS";
						return;
					}
<<<<<<< HEAD
					labelGPS.Text = string.Format("Latitude: {0} \nLongitude: {1} \nTimestamp: {2}", position.Latitude, position.Longitude, position.Timestamp);
=======

					labelGPS.Text = string.Format("Time: {0} \nLatitude: {1} \nLongitude: {2}", position.Timestamp, position.Latitude, position.Longitude);
>>>>>>> d0ebf4a6c559268dcebe268dac395ea7a0439d63
				}
				catch(Exception ex){
					await DisplayAlert("Error", "Some error: " + ex, "OK");
				}
				watch.Stop();
				long ms = watch.ElapsedMilliseconds;
				GpsTime.Text = string.Format("MS: {0}",ms);
			};
		}
	}
}

