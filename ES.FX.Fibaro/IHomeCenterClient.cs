using System;
using System.Net.Http;
using ES.FX.Fibaro.Api.Devices;
using ES.FX.Fibaro.Api.Settings;
using ES.FX.Fibaro.Api.Status;

namespace ES.FX.Fibaro
{
    public interface IHomeCenterClient : IDisposable
    {
        HttpClient HttpClient { get; }
        IDevicesClient Devices { get; }
        IStatusClient Status { get; }
        ISettingsClient Settings { get; }
    }
}