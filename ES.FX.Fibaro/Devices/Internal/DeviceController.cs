using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using ES.FX.Fibaro.Devices.Internal.Models;

namespace ES.FX.Fibaro.Devices.Internal
{
    internal class DeviceController : IDeviceController
    {
        private readonly Lazy<ApiHttpClient> _apiHttpClient;
        private readonly DevicePropertiesController _devicePropertiesController;
        private DeviceModel _inner = new DeviceModel();

        public DeviceController(ILifetimeScope container, Lazy<ApiHttpClient> apiHttpClient)
        {
            _apiHttpClient = apiHttpClient;
            _devicePropertiesController = container.Resolve<DevicePropertiesController>();
        }

        private ApiHttpClient ApiHttpClient => _apiHttpClient.Value;

        public long Id => _inner.Id;
        public string Name => _inner.Name;
        public long RoomId => _inner.RoomId;
        public string Type => _inner.Type;
        public string BaseType => _inner.BaseType;
        public bool Enabled => _inner.Enabled;
        public bool Visible => _inner.Visible;
        public bool? IsPlugin => _inner.IsPlugin;
        public long? ParentId => _inner.ParentId;
        public long? RemoteGatewayId => _inner.RemoteGatewayId;
        public bool? ViewXml => _inner.ViewXml;
        public bool? ConfigXml => _inner.ConfigXml;
        public string[] Interfaces => _inner.Interfaces;
        public IReadOnlyDictionary<string, long> Actions => _inner.Actions;
        public long Created => _inner.Created;
        public long Modified => _inner.Modified;
        public long SortOrder => _inner.SortOrder;
        public object[] View => _inner.View;

        public IDevicePropertiesController Properties => _devicePropertiesController;

        public async Task RunAction(string actionName)
        {
            var result = await ApiHttpClient.PostAsync($"api/devices/{Id}/action/{actionName}", null);
            result.EnsureSuccessStatusCode();
        }

        internal void Update(DeviceModel device)
        {
            _inner = device;
            _devicePropertiesController.PropertiesJObject = _inner.Properties;
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }
    }
}