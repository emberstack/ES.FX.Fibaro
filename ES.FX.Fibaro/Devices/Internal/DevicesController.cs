using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using ES.FX.Fibaro.Devices.Internal.Models;

namespace ES.FX.Fibaro.Devices.Internal
{
    internal class DevicesController : IDevicesController
    {
        private readonly Lazy<ApiHttpClient> _apiClient;
        private readonly ILifetimeScope _container;

        private readonly ConcurrentDictionary<long, IDeviceController> _deviceControllers =
            new ConcurrentDictionary<long, IDeviceController>();

        public DevicesController(Lazy<ApiHttpClient> apiClient, ILifetimeScope container)
        {
            _apiClient = apiClient;
            _container = container;
        }

        private ApiHttpClient ApiClient => _apiClient.Value;


        public async Task<IReadOnlyList<IDeviceController>> List()
        {
            var devices = await ListKeyed();
            return devices.Values.ToList();
        }

        public async Task<IReadOnlyDictionary<long, IDeviceController>> ListKeyed()
        {
            var devices = await ApiClient.GetAsync<DeviceModel[]>("api/devices");
            foreach (var device in devices.OrderBy(s => s.Id))
            {
                var controller = (DeviceController) _deviceControllers.AddOrUpdate(device.Id,
                    _container.Resolve<DeviceController>(),
                    (id, existingController) => existingController);
                controller.Update(device);
            }

            return _deviceControllers;
        }

        public async Task<IDeviceController> GetById(long id)
        {
            var device = await ApiClient.GetAsync<DeviceModel>($"api/devices/{id}");
            var controller = (DeviceController) _deviceControllers.AddOrUpdate(device.Id,
                _container.Resolve<DeviceController>(),
                (oldId, existingController) => existingController);
            controller.Update(device);
            return controller;
        }
    }
}