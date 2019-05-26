using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Settings.Interfaces;

namespace ES.FX.Fibaro.Api.Settings
{
    public interface ISettingsClient
    {
        Task<string> GetGeneralSettingsJson();
        Task<IGeneralSettings> GetGeneralSettings();
        Task<string> GetLocationSettingsJson();
        Task<ILocationSettings> GetLocationSettings();
        Task<string> GetNetworkSettingsJson();
        Task<INetworkSettings> GetNetworkSettings();
    }
}