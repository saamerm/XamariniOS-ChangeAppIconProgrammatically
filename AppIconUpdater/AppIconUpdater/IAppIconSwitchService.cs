using System;
using System.Threading.Tasks;

namespace AppIconUpdater
{
    public interface IAppIconSwitchService
    {
        Task SwitchAppIcon(string iconName);
    }
}