using Microsoft.Web.WebView2.Core;
using System;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Drawing.Imaging;
using BingMapsRESTToolkit;
using System.Drawing;

namespace google_maps
{
    public partial class Anasayfa : Form
    {

        public const string BingMapsApiKey = "YOUR_API_KEY";
        public const string BingMapsGeocodingApiUrl = "https://dev.virtualearth.net/REST/v1/Locations";

        GeocodeRequest geocodeRequest = new GeocodeRequest();

        public Anasayfa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            gMapControl1.MouseWheelZoomEnabled = true;
            GMapProviders.BingMap.ClientKey = BingMapsApiKey;
            gMapControl1.MapProvider = GMapProviders.BingMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            double lat = 36.533;
            double lon = 12.28;
            gMapControl1.Position = new PointLatLng(lat, lon);

        }

        private async void picSearch_Click(object sender, EventArgs e)
        {
            string konum = txtKonum.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(konum))
                {
                    MessageBox.Show("Geçerli bir adres giriniz");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            await GeocodeSearchQuery(konum);
        }

        private async Task GeocodeSearchQuery(string query)
        {
            using (var httpClient = new HttpClient())
            {
                string requestUrl = $"{BingMapsGeocodingApiUrl}?q={Uri.EscapeDataString(query)}&key={BingMapsApiKey}";
                var response = await httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content);

                    var resources = json["resourceSets"]?[0]?["resources"];
                    if (resources != null && resources.HasValues)
                    {
                        var location = resources[0]?["point"]?["coordinates"];
                        if (location != null && location.HasValues)
                        {
                            double latitude = (double)location[0];
                            double longitude = (double)location[1];

                            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
                            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                            gMapControl1.Position = new GMap.NET.PointLatLng(latitude, longitude);
                            gMapControl1.Zoom = 16;


                        }
                    }

                }
                else
                {
                    MessageBox.Show("Geocoding failed.");
                }
            }
        }

        private void txtKonum_KeyDown(object sender, KeyEventArgs e)
        {
            //clicking on enter key searches
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                picSearch_Click(sender, e);
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtKonum_TextChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sender is GMap.NET.WindowsForms.GMapControl gmapControl)
            {
                MouseEventArgs mouseEventArgs = e as MouseEventArgs;

                if (mouseEventArgs != null)
                {
                    GMap.NET.PointLatLng clickedPosition = gmapControl.FromLocalToLatLng(mouseEventArgs.X, mouseEventArgs.Y);

                    double latitude = clickedPosition.Lat;
                    double longitude = clickedPosition.Lng;

                    string coordinatesString = $"Lat: {latitude}, Long: {longitude}";

                    // Add the coordinates string to the ListBox
                    lstCoordinates.Items.Add(coordinatesString);

                }
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
