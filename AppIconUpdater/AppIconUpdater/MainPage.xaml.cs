using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIconUpdater
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Xamarin_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var iconSwitcher = DependencyService.Get<IAppIconSwitchService>();
            await iconSwitcher.SwitchAppIcon(null);
        }

        async void Maui_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var iconSwitcher = DependencyService.Get<IAppIconSwitchService>();
            await iconSwitcher.SwitchAppIcon("MauiLogo");
        }
    }
}
