using System;
using System.Threading.Tasks;
using AppIconUpdater;
using AppIconUpdater.iOS;
using UIKit;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(AppIconSwitchService))]
namespace AppIconUpdater.iOS
{
    public class AppIconSwitchService : IAppIconSwitchService
    {
        public async Task SwitchAppIcon(string iconName)
        {
            if (UIApplication.SharedApplication.SupportsAlternateIcons)
            {
                if (iconName == "MauiLogo")
                    await UIApplication.SharedApplication.SetAlternateIconNameAsync(iconName);
                else
                    UIApplication.SharedApplication.SetAlternateIconName(null, (error) => { Console.WriteLine(error); });
            }
        }
    }
}
