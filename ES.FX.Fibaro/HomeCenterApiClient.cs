using Autofac;
using ES.FX.Fibaro.Devices;
using ES.FX.Fibaro.Devices.Internal;
using ES.FX.Fibaro.Settings;
using ES.FX.Fibaro.Settings.Internal;
using ES.FX.Fibaro.Status;
using ES.FX.Fibaro.Status.Models.Internal;

namespace ES.FX.Fibaro
{
    public class HomeCenterApiClient
    {
        private readonly ILifetimeScope _container;

        public HomeCenterApiClient(string hostAddress, string username, string password)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new ApiHttpClient(hostAddress, username, password))
                .AsSelf().SingleInstance();

            builder.RegisterType<StatusController>().AsImplementedInterfaces();
            builder.RegisterType<SettingsController>().AsImplementedInterfaces();
            builder.RegisterType<GeneralSettingsController>().AsImplementedInterfaces();
            builder.RegisterType<LocationSettingsController>().AsImplementedInterfaces();
            builder.RegisterType<NetworkSettingsController>().AsImplementedInterfaces();
            builder.RegisterType<DevicesController>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<DeviceController>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<DevicePropertiesController>().AsImplementedInterfaces().AsSelf();

            _container = builder.Build();
        }


        public ISettingsController Settings => _container.Resolve<ISettingsController>();
        public IDevicesController Devices => _container.Resolve<IDevicesController>();
        public IStatusController Status => _container.Resolve<IStatusController>();
    }
}