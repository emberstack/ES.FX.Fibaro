using System.Threading.Tasks;
using ES.FX.Fibaro.Api.Status.Interfaces;

namespace ES.FX.Fibaro.Api.Status
{
    public interface IStatusClient
    {
        Task<string> GetLoginStatusJson();
        Task<ILoginStatus> GetLoginStatus();
    }
}