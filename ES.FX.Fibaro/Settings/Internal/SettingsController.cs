using System;

namespace ES.FX.Fibaro.Settings.Internal
{
    internal class SettingsController : ISettingsController
    {
        private readonly Lazy<IGeneralSettingsController> _generalSettingsControllerLazy;
        private readonly Lazy<ILocationSettingsController> _locationSettingsControllerLazy;
        private readonly Lazy<INetworkSettingsController> _networkSettingsControllerLazy;


        public SettingsController(
            Lazy<IGeneralSettingsController> generalSettingsControllerLazy,
            Lazy<ILocationSettingsController> locationSettingsControllerLazy,
            Lazy<INetworkSettingsController> networkSettingsControllerLazy
        )
        {
            _generalSettingsControllerLazy = generalSettingsControllerLazy;
            _locationSettingsControllerLazy = locationSettingsControllerLazy;
            _networkSettingsControllerLazy = networkSettingsControllerLazy;
        }


        public IGeneralSettingsController General => _generalSettingsControllerLazy.Value;
        public ILocationSettingsController Location => _locationSettingsControllerLazy.Value;
        public INetworkSettingsController Network => _networkSettingsControllerLazy.Value;
    }
}