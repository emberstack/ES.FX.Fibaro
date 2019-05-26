using System.Runtime.Serialization;
using ES.FX.Fibaro.Api.Devices.Interfaces;
using ES.FX.Fibaro.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Api.Devices.Models
{
    internal class DeviceProperties : IDeviceProperties
    {
        [JsonProperty("armConditions", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<ArmConditions>))]
        public IArmConditions ArmConditions { get; set; }

        [JsonProperty("UIMessageSendTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UiMessageSendTime { get; set; }

        [JsonProperty("autoConfig", NullValueHandling = NullValueHandling.Ignore)]
        public long? AutoConfig { get; set; }

        [JsonProperty("configured", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Configured { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        [JsonProperty("dead", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dead { get; set; }

        [JsonProperty("deviceControlType", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeviceControlType { get; set; }

        [JsonProperty("deviceIcon")]
        public long DeviceIcon { get; set; }

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public long? Disabled { get; set; }

        [JsonProperty("emailNotificationID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EmailNotificationId { get; set; }

        [JsonProperty("emailNotificationType", NullValueHandling = NullValueHandling.Ignore)]
        public long? EmailNotificationType { get; set; }

        [JsonProperty("endPoint", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndPoint { get; set; }

        [JsonProperty("endPointId", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndPointId { get; set; }

        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public string Log { get; set; }

        [JsonProperty("logTemp", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTemp { get; set; }

        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        [JsonProperty("markAsDead", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkAsDead { get; set; }

        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        [JsonProperty("nodeID", NullValueHandling = NullValueHandling.Ignore)]
        public long? NodeId { get; set; }

        [JsonProperty("nodeId", NullValueHandling = NullValueHandling.Ignore)]
        public long? PropertiesNodeId { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<Parameter[]>))]
        public IParameter[] Parameters { get; set; }

        [JsonProperty("parametersTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public string ParametersTemplate { get; set; }

        [JsonProperty("pollingDeadDevice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PollingDeadDevice { get; set; }

        [JsonProperty("pollingTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? PollingTime { get; set; }

        [JsonProperty("pollingTimeNext", NullValueHandling = NullValueHandling.Ignore)]
        public long? PollingTimeNext { get; set; }

        [JsonProperty("pollingTimeSec", NullValueHandling = NullValueHandling.Ignore)]
        public long? PollingTimeSec { get; set; }

        [JsonProperty("productInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductInfo { get; set; }

        [JsonProperty("pushNotificationID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PushNotificationId { get; set; }

        [JsonProperty("pushNotificationType", NullValueHandling = NullValueHandling.Ignore)]
        public long? PushNotificationType { get; set; }

        [JsonProperty("remoteGatewayId", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemoteGatewayId { get; set; }

        [JsonProperty("requestNodeNeighborStat", NullValueHandling = NullValueHandling.Ignore)]
        public long? RequestNodeNeighborStat { get; set; }

        [JsonProperty("requestNodeNeighborStatTimeStemp", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestNodeNeighborStatTimeStemp { get; set; }

        [JsonProperty("requestNodeNeighborState", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestNodeNeighborState { get; set; }

        [JsonProperty("requestNodeNeighborStateTimeStemp", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestNodeNeighborStateTimeStemp { get; set; }

        [JsonProperty("saveLogs", NullValueHandling = NullValueHandling.Ignore)]
        public bool SaveLogs { get; set; }

        [JsonProperty("serialNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        [JsonProperty("showChildren", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShowChildren { get; set; }

        [JsonProperty("smsNotificationID", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNotificationId { get; set; }

        [JsonProperty("smsNotificationType", NullValueHandling = NullValueHandling.Ignore)]
        public long? SmsNotificationType { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("sunriseHour", NullValueHandling = NullValueHandling.Ignore)]
        public string SunriseHour { get; set; }

        [JsonProperty("sunsetHour", NullValueHandling = NullValueHandling.Ignore)]
        public string SunsetHour { get; set; }

        [JsonProperty("useTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTemplate { get; set; }

        [JsonProperty("userDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDescription { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }

        [JsonProperty("zwaveBuildVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ZwaveBuildVersion { get; set; }

        [JsonProperty("zwaveCompany", NullValueHandling = NullValueHandling.Ignore)]
        public string ZwaveCompany { get; set; }

        [JsonProperty("zwaveInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string ZwaveInfo { get; set; }

        [JsonProperty("zwaveRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string ZwaveRegion { get; set; }

        [JsonProperty("zwaveVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ZwaveVersion { get; set; }

        [JsonProperty("Email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("HotelModeRoom", NullValueHandling = NullValueHandling.Ignore)]
        public long? HotelModeRoom { get; set; }

        [JsonProperty("LastPwdChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastPwdChange { get; set; }

        [JsonProperty("Latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("LocationTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationTime { get; set; }

        [JsonProperty("LocationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LocationTimestamp { get; set; }

        [JsonProperty("Longitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        [JsonProperty("PreviousLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? PreviousLatitude { get; set; }

        [JsonProperty("PreviousLocation", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousLocation { get; set; }

        [JsonProperty("PreviousLocationTime", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousLocationTime { get; set; }

        [JsonProperty("PreviousLocationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PreviousLocationTimestamp { get; set; }

        [JsonProperty("PreviousLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? PreviousLongitude { get; set; }

        [JsonProperty("SendNotifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendNotifications { get; set; }

        [JsonProperty("TrackUser", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrackUser { get; set; }

        [JsonProperty("UserType", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }

        [JsonProperty("atHome", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AtHome { get; set; }

        [JsonProperty("fidUuid", NullValueHandling = NullValueHandling.Ignore)]
        public string FidUuid { get; set; }

        [JsonProperty("firmwareUpdateLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirmwareUpdateLevel { get; set; }

        [JsonProperty("initialWizard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitialWizard { get; set; }

        [JsonProperty("sipDisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string SipDisplayName { get; set; }

        [JsonProperty("sipUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string SipUserId { get; set; }

        [JsonProperty("sipUserPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string SipUserPassword { get; set; }

        [JsonProperty("useOptionalArmPin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOptionalArmPin { get; set; }

        [JsonProperty("usePin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePin { get; set; }

        [JsonProperty("ConditionCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConditionCode { get; set; }

        [JsonProperty("ConditionCodeConverted", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConditionCodeConverted { get; set; }

        [JsonProperty("Humidity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Humidity { get; set; }

        [JsonProperty("Pressure", NullValueHandling = NullValueHandling.Ignore)]
        public double? Pressure { get; set; }

        [JsonProperty("Temperature", NullValueHandling = NullValueHandling.Ignore)]
        public double? Temperature { get; set; }

        [JsonProperty("WeatherCondition", NullValueHandling = NullValueHandling.Ignore)]
        public string WeatherCondition { get; set; }

        [JsonProperty("Wind", NullValueHandling = NullValueHandling.Ignore)]
        public double? Wind { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Categories { get; set; }

        [JsonProperty("deadReason", NullValueHandling = NullValueHandling.Ignore)]
        public string DeadReason { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }

        [JsonProperty("ui.Current_Weather_Label.caption", NullValueHandling = NullValueHandling.Ignore)]
        public string UiCurrentWeatherLabelCaption { get; set; }

        [JsonProperty("ui.config.hidden.caption", NullValueHandling = NullValueHandling.Ignore)]
        public string UiConfigHiddenCaption { get; set; }

        [JsonProperty("ui.config.hidden.enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UiConfigHiddenEnabled { get; set; }

        [JsonProperty("ui.config.section1.caption", NullValueHandling = NullValueHandling.Ignore)]
        public string UiConfigSection1Caption { get; set; }

        [JsonProperty("ui.config.section1.enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UiConfigSection1Enabled { get; set; }

        [JsonProperty("batteryLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? BatteryLevel { get; set; }

        [JsonProperty("batteryLowNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BatteryLowNotification { get; set; }

        [JsonProperty("defInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefInterval { get; set; }

        [JsonProperty("deviceSpecificData", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceSpecificData { get; set; }

        [JsonProperty("deviceSpecificIdType", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceSpecificIdType { get; set; }

        [JsonProperty("deviceState", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceState { get; set; }

        [JsonProperty("lastWorkingRoute", NullValueHandling = NullValueHandling.Ignore)]
        public long[] LastWorkingRoute { get; set; }

        [JsonProperty("lastWorkingRouteRequestStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string LastWorkingRouteRequestStatus { get; set; }

        [JsonProperty("lastWorkingRouteRequestTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastWorkingRouteRequestTimestamp { get; set; }

        [JsonProperty("lastWorkingRouteResponseTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastWorkingRouteResponseTimestamp { get; set; }

        [JsonProperty("maxInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxInterval { get; set; }

        [JsonProperty("minInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinInterval { get; set; }

        [JsonProperty("neighborList", NullValueHandling = NullValueHandling.Ignore)]
        public long[] NeighborList { get; set; }

        [JsonProperty("neighborListRequestStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string NeighborListRequestStatus { get; set; }

        [JsonProperty("neighborListRequestTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? NeighborListRequestTimestamp { get; set; }

        [JsonProperty("neighborListResponseTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? NeighborListResponseTimestamp { get; set; }

        [JsonProperty("stepInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? StepInterval { get; set; }

        [JsonProperty("wakeUpTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? WakeUpTime { get; set; }

        [JsonProperty("zwaveSoftwareVersion", NullValueHandling = NullValueHandling.Ignore)]
        public object ZwaveSoftwareVersion { get; set; }

        [JsonProperty("alarmDelay", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmDelay { get; set; }

        [JsonProperty("alarmExclude", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmExclude { get; set; }

        [JsonProperty("alarmLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmLevel { get; set; }

        [JsonProperty("alarmTimeTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmTimeTimestamp { get; set; }

        [JsonProperty("alarmType", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmType { get; set; }

        [JsonProperty("armConfig", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArmConfig { get; set; }

        [JsonProperty("armDelay", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArmDelay { get; set; }

        //[JsonProperty("armError", NullValueHandling = NullValueHandling.Ignore)]
        //public ArmError ArmError { get; set; }

        [JsonProperty("armTimeTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ArmTimeTimestamp { get; set; }

        [JsonProperty("armed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Armed { get; set; }

        [JsonProperty("fibaroAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FibaroAlarm { get; set; }

        [JsonProperty("firmwareUpdate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<FirmwareUpdate>))]
        public IFirmwareUpdate FirmwareUpdate { get; set; }

        [JsonProperty("lastBreached", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastBreached { get; set; }

        [JsonProperty("tamper", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tamper { get; set; }

        [JsonProperty("tamperMode", NullValueHandling = NullValueHandling.Ignore)]
        public string TamperMode { get; set; }

        [JsonProperty("tamperOperatingModes", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TamperOperatingModes { get; set; }

        [JsonProperty("updateVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateVersion { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        [JsonProperty("showFireAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFireAlarm { get; set; }

        [JsonProperty("showFreezeAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFreezeAlarm { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("deviceGroup", NullValueHandling = NullValueHandling.Ignore)]
        public object[] DeviceGroup { get; set; }

        [JsonProperty("deviceGroupMaster", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeviceGroupMaster { get; set; }

        [JsonProperty("isLight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLight { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public double? Power { get; set; }

        [JsonProperty("powerConsumption", NullValueHandling = NullValueHandling.Ignore)]
        public long? PowerConsumption { get; set; }

        [JsonProperty("showEnergy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEnergy { get; set; }

        [JsonProperty("pollingInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? PollingInterval { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("energy", NullValueHandling = NullValueHandling.Ignore)]
        public double? Energy { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<Icon>))]
        public IIcon Icon { get; set; }

        [JsonProperty("RFProtectionState", NullValueHandling = NullValueHandling.Ignore)]
        public long? RfProtectionState { get; set; }

        [JsonProperty("RFProtectionSupport", NullValueHandling = NullValueHandling.Ignore)]
        public long? RfProtectionSupport { get; set; }

        [JsonProperty("localProtectionState", NullValueHandling = NullValueHandling.Ignore)]
        public long? LocalProtectionState { get; set; }

        [JsonProperty("localProtectionSupport", NullValueHandling = NullValueHandling.Ignore)]
        public long? LocalProtectionSupport { get; set; }

        [JsonProperty("protectionExclusiveControl", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProtectionExclusiveControl { get; set; }

        [JsonProperty("protectionExclusiveControlSupport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProtectionExclusiveControlSupport { get; set; }

        [JsonProperty("protectionState", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProtectionState { get; set; }

        [JsonProperty("protectionTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProtectionTimeout { get; set; }

        [JsonProperty("protectionTimeoutSupport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProtectionTimeoutSupport { get; set; }

        [JsonProperty("centralSceneSupport", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<CentralSceneSupport[]>))]
        public ICentralSceneSupport[] CentralSceneSupport { get; set; }

        [JsonProperty("DeviceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceToken { get; set; }

        [JsonProperty("DeviceUID", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceUid { get; set; }

        [JsonProperty("Push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Push { get; set; }

        [JsonProperty("lastLoggedUser", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastLoggedUser { get; set; }

        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public long? Port { get; set; }

        [JsonProperty("currentIcon", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentIcon { get; set; }

        [JsonProperty("mainLoop", NullValueHandling = NullValueHandling.Ignore)]
        public string MainLoop { get; set; }

        [JsonProperty("ui.Temp.value", NullValueHandling = NullValueHandling.Ignore)]
        public string UiTempValue { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ConcreteTypeConverter<Row[]>))]
        public IRow[] Rows { get; set; }

        [JsonProperty("defaultPartyTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefaultPartyTime { get; set; }

        [JsonProperty("heatingZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public long? HeatingZoneId { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public long? Mode { get; set; }

        [JsonProperty("nextTargetLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextTargetLevel { get; set; }

        [JsonProperty("nextTargetLevelTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextTargetLevelTimestamp { get; set; }

        [JsonProperty("supportedModes", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportedModes { get; set; }

        [JsonProperty("targetLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetLevel { get; set; }

        [JsonProperty("targetLevelTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetLevelTimestamp { get; set; }

        [JsonProperty("thermostatState", NullValueHandling = NullValueHandling.Ignore)]
        public string ThermostatState { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public long? State { get; set; }

        [JsonProperty("switchAllMode", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchAllMode { get; set; }


        [JsonExtensionData]
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public JObject ExtensionData { get; set; }

        public dynamic ExtensionDataDynamic { get; private set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            ExtensionDataDynamic = ExtensionData != null ? ExtensionData.ToObject<dynamic>() : new object();
        }
    }
}