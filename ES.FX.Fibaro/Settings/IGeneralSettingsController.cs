using System.Threading.Tasks;
using ES.FX.Fibaro.Settings.Models;

namespace ES.FX.Fibaro.Settings
{
    public interface IGeneralSettingsController
    {
        Task<IGeneralSettingsModel> Get();
    }
}