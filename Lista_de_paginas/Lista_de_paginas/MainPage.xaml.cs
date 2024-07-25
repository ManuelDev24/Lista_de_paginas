using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Lista_de_paginas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ir_html_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/HTML", BrowserLaunchMode.SystemPreferred);
        }

        private void Ir_css_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Hoja_de_estilos_en_cascada", BrowserLaunchMode.SystemPreferred);
        }

        private void ver_powerbi_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://powerbi.microsoft.com/es-es/what-is-power-bi/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
