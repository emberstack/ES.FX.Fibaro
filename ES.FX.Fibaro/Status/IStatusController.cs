using System.Threading.Tasks;
using ES.FX.Fibaro.Status.Models;

namespace ES.FX.Fibaro.Status
{
    public interface IStatusController
    {
        Task<ILoginStatus> GetLoginStatus();
    }
}