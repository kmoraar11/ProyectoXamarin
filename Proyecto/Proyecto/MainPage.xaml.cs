using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Proyecto.Recursos;
using Proyecto.Modelos;

namespace Proyecto
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RestService _restService;
        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();

        }

        async void OnButtonClicked(Object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                WheatherData wheatherData = await _restService.GetWheatherDataAsync(GenerateRequestUri(Constantes.OpenWeatherMapEndpoint));
                BindingContext = wheatherData;
            }

        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?q={cityEntry.Text}";
            requestUri += $"&APPID={Constantes.OpenWeatherMapAPIKey}";
            return requestUri;

        }
    }
}
