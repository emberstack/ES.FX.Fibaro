using Newtonsoft.Json;

namespace ES.FX.Fibaro.Remote
{
    public class DeviceProperties
    {
        [JsonProperty("UIMessageSendTime")]
        public string UiMessageSendTime { get; set; }

        [JsonProperty("autoConfig")]
        public string AutoConfig { get; set; }

        [JsonProperty("configured")]
        public bool? Configured { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        //[JsonProperty("dead")]
        //public bool? Dead { get; set; }

        //[JsonProperty("deviceControlType")]
        //public DeviceControlType? DeviceControlType { get; set; }

        //[JsonProperty("deviceIcon")]
        //public DeviceIcon DeviceIcon { get; set; }

        [JsonProperty("disabled")]
        public string Disabled { get; set; }

        //[JsonProperty("emailNotificationID")]
        //public RfProtectionState? EmailNotificationId { get; set; }

        //[JsonProperty("emailNotificationType")]
        //public RfProtectionState? EmailNotificationType { get; set; }

        [JsonProperty("endPoint")]
        public string EndPoint { get; set; }

        //[JsonProperty("endPointId")]
        //public EndPointId? EndPointId { get; set; }

        //[JsonProperty("liliOffCommand")]
        //public LiliOffCommand? LiliOffCommand { get; set; }

        //[JsonProperty("liliOnCommand")]
        //public LiliOffCommand? LiliOnCommand { get; set; }

        //[JsonProperty("log")]
        //public LiliOffCommand? Log { get; set; }

        //[JsonProperty("logTemp")]
        //public LiliOffCommand? LogTemp { get; set; }

        //[JsonProperty("manufacturer")]
        //public LiliOffCommand? Manufacturer { get; set; }

        //[JsonProperty("markAsDead")]
        //public IsLight? MarkAsDead { get; set; }

        //[JsonProperty("model")]
        //public LiliOffCommand? Model { get; set; }

        [JsonProperty("nodeID")]
        public string NodeId { get; set; }

        [JsonProperty("nodeId")]
        public string PropertiesNodeId { get; set; }

        //[JsonProperty("parameters")]
        //public Parameter[] Parameters { get; set; }

        //[JsonProperty("parametersTemplate")]
        //public ParametersTemplate? ParametersTemplate { get; set; }

        [JsonProperty("pollingDeadDevice")]
        public string PollingDeadDevice { get; set; }

        [JsonProperty("pollingTime")]
        public string PollingTime { get; set; }

        [JsonProperty("pollingTimeNext")]
        public string PollingTimeNext { get; set; }

        [JsonProperty("pollingTimeSec")]
        public long? PollingTimeSec { get; set; }

        //[JsonProperty("productInfo")]
        //public ProductInfo? ProductInfo { get; set; }

        //[JsonProperty("pushNotificationID")]
        //public RfProtectionState? PushNotificationId { get; set; }

        //[JsonProperty("pushNotificationType")]
        //public RfProtectionState? PushNotificationType { get; set; }

        //[JsonProperty("remoteGatewayId")]
        //public RfProtectionState? RemoteGatewayId { get; set; }

        [JsonProperty("requestNodeNeighborStat")]
        public string RequestNodeNeighborStat { get; set; }

        [JsonProperty("requestNodeNeighborStatTimeStemp")]
        public string RequestNodeNeighborStatTimeStemp { get; set; }

        [JsonProperty("requestNodeNeighborState")]
        public string RequestNodeNeighborState { get; set; }

        [JsonProperty("requestNodeNeighborStateTimeStemp")]
        public string RequestNodeNeighborStateTimeStemp { get; set; }

        [JsonProperty("saveLogs")]
        public string SaveLogs { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("showChildren")]
        public string ShowChildren { get; set; }

        [JsonProperty("smsNotificationID")]
        public string SmsNotificationId { get; set; }

        [JsonProperty("smsNotificationType")]
        public string SmsNotificationType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sunriseHour")]
        public string SunriseHour { get; set; }

        [JsonProperty("sunsetHour")]
        public string SunsetHour { get; set; }

        [JsonProperty("useTemplate")]
        public string UseTemplate { get; set; }

        [JsonProperty("userDescription")]
        public string UserDescription { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("zwaveBuildVersion")]
        public string ZwaveBuildVersion { get; set; }

        [JsonProperty("zwaveCompany")]
        public string ZwaveCompany { get; set; }

        [JsonProperty("zwaveInfo")]
        public string ZwaveInfo { get; set; }

        [JsonProperty("zwaveRegion")]
        public string ZwaveRegion { get; set; }

        [JsonProperty("zwaveVersion")]
        public string ZwaveVersion { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("HotelModeRoom")]
        public string HotelModeRoom { get; set; }

        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("LocationTime")]
        public string LocationTime { get; set; }

        [JsonProperty("LocationTimestamp")]
        public string LocationTimestamp { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }

        [JsonProperty("PreviousLatitude")]
        public string PreviousLatitude { get; set; }

        [JsonProperty("PreviousLocation")]
        public string PreviousLocation { get; set; }

        [JsonProperty("PreviousLocationTime")]
        public string PreviousLocationTime { get; set; }

        [JsonProperty("PreviousLocationTimestamp")]
        public string PreviousLocationTimestamp { get; set; }

        [JsonProperty("PreviousLongitude")]
        public string PreviousLongitude { get; set; }

        [JsonProperty("SendNotifications")]
        public string SendNotifications { get; set; }

        [JsonProperty("TrackUser")]
        public string TrackUser { get; set; }

        [JsonProperty("UserType")]
        public string UserType { get; set; }

        [JsonProperty("firmwareUpdateLevel")]
        public string FirmwareUpdateLevel { get; set; }

        [JsonProperty("initialWizard")]
        public string InitialWizard { get; set; }

        [JsonProperty("sipDisplayName")]
        public string SipDisplayName { get; set; }

        [JsonProperty("sipUserID")]
        public string SipUserId { get; set; }

        [JsonProperty("sipUserPassword")]
        public string SipUserPassword { get; set; }

        [JsonProperty("useOptionalArmPin")]
        public string UseOptionalArmPin { get; set; }

        [JsonProperty("usePin")]
        public string UsePin { get; set; }

        [JsonProperty("ConditionCode")]
        public string ConditionCode { get; set; }

        [JsonProperty("ConditionCodeConverted")]
        public string ConditionCodeConverted { get; set; }

        [JsonProperty("Humidity")]
        public string Humidity { get; set; }

        [JsonProperty("Pressure")]
        public string Pressure { get; set; }

        [JsonProperty("Temperature")]
        public string Temperature { get; set; }

        [JsonProperty("WeatherCondition")]
        public string WeatherCondition { get; set; }

        [JsonProperty("Wind")]
        public string Wind { get; set; }

        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        [JsonProperty("ui.Current_Weather_Label.caption")]
        public string UiCurrentWeatherLabelCaption { get; set; }

        [JsonProperty("ui.config.hidden.caption")]
        public string UiConfigHiddenCaption { get; set; }

        [JsonProperty("ui.config.hidden.enabled")]
        public bool? UiConfigHiddenEnabled { get; set; }

        [JsonProperty("ui.config.section1.caption")]
        public string UiConfigSection1Caption { get; set; }

        [JsonProperty("ui.config.section1.enabled")]
        public bool? UiConfigSection1Enabled { get; set; }

        [JsonProperty("batteryLevel")]
        public string BatteryLevel { get; set; }

        [JsonProperty("batteryLowNotification")]
        public string BatteryLowNotification { get; set; }

        [JsonProperty("defInterval")]
        public string DefInterval { get; set; }

        [JsonProperty("deviceSpecificData")]
        public string DeviceSpecificData { get; set; }

        [JsonProperty("deviceSpecificIdType")]
        public string DeviceSpecificIdType { get; set; }

        [JsonProperty("deviceState")]
        public string DeviceState { get; set; }

        [JsonProperty("maxInterval")]
        public string MaxInterval { get; set; }

        [JsonProperty("minInterval")]
        public string MinInterval { get; set; }

        [JsonProperty("stepInterval")]
        public string StepInterval { get; set; }

        [JsonProperty("wakeUpTime")]
        public long? WakeUpTime { get; set; }

        [JsonProperty("zwaveSoftwareVersion")]
        public string ZwaveSoftwareVersion { get; set; }

        [JsonProperty("alarmDelay")]
        public string AlarmDelay { get; set; }

        [JsonProperty("alarmExclude")]
        public string AlarmExclude { get; set; }

        [JsonProperty("alarmLevel")]
        public string AlarmLevel { get; set; }

        [JsonProperty("alarmTimeTimestamp")]
        public string AlarmTimeTimestamp { get; set; }

        [JsonProperty("alarmType")]
        public string AlarmType { get; set; }

        [JsonProperty("armConditions")]
        public string ArmConditions { get; set; }

        [JsonProperty("armConfig")]
        public string ArmConfig { get; set; }

        [JsonProperty("armDelay")]
        public string ArmDelay { get; set; }

        [JsonProperty("armError")]
        public string ArmError { get; set; }

        [JsonProperty("armTimeTimestamp")]
        public string ArmTimeTimestamp { get; set; }

        [JsonProperty("armed")]
        public string Armed { get; set; }

        [JsonProperty("fibaroAlarm")]
        public string FibaroAlarm { get; set; }

        [JsonProperty("firmwareUpdate")]
        public string FirmwareUpdate { get; set; }

        [JsonProperty("lastBreached")]
        public string LastBreached { get; set; }

        [JsonProperty("tamper")]
        public string Tamper { get; set; }

        [JsonProperty("tamperMode")]
        public string TamperMode { get; set; }

        [JsonProperty("tamperOperatingModes")]
        public string TamperOperatingModes { get; set; }

        [JsonProperty("updateVersion")]
        public string UpdateVersion { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("showFireAlarm")]
        public string ShowFireAlarm { get; set; }

        [JsonProperty("showFreezeAlarm")]
        public string ShowFreezeAlarm { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("deviceGroup")]
        public string DeviceGroup { get; set; }

        [JsonProperty("deviceGroupMaster")]
        public string DeviceGroupMaster { get; set; }

        [JsonProperty("isLight")]
        public string IsLight { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("powerConsumption")]
        public string PowerConsumption { get; set; }

        [JsonProperty("showEnergy")]
        public string ShowEnergy { get; set; }

        [JsonProperty("pollingInterval")]
        public string PollingInterval { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("energy")]
        public string Energy { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("RFProtectionState")]
        public string RfProtectionState { get; set; }

        [JsonProperty("RFProtectionSupport")]
        public string RfProtectionSupport { get; set; }

        [JsonProperty("localProtectionState")]
        public string LocalProtectionState { get; set; }

        [JsonProperty("localProtectionSupport")]
        public string LocalProtectionSupport { get; set; }

        [JsonProperty("protectionExclusiveControl")]
        public string ProtectionExclusiveControl { get; set; }

        [JsonProperty("protectionExclusiveControlSupport")]
        public string ProtectionExclusiveControlSupport { get; set; }

        [JsonProperty("protectionState")]
        public string ProtectionState { get; set; }

        [JsonProperty("protectionTimeout")]
        public string ProtectionTimeout { get; set; }

        [JsonProperty("protectionTimeoutSupport")]
        public string ProtectionTimeoutSupport { get; set; }

        [JsonProperty("centralSceneSupport")]
        public string CentralSceneSupport { get; set; }

        [JsonProperty("DeviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("DeviceUID")]
        public string DeviceUid { get; set; }

        [JsonProperty("Push")]
        public string Push { get; set; }

        [JsonProperty("lastLoggedUser")]
        public string LastLoggedUser { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("port")]
        public long? Port { get; set; }

        [JsonProperty("currentIcon")]
        public string CurrentIcon { get; set; }

        [JsonProperty("mainLoop")]
        public string MainLoop { get; set; }

        [JsonProperty("ui.Temp.value")]
        public string UiTempValue { get; set; }

        [JsonProperty("visible")]
        public string Visible { get; set; }

        //[JsonProperty("rows")]
        //public Row[] Rows { get; set; }

        [JsonProperty("defaultPartyTime")]
        public string DefaultPartyTime { get; set; }

        [JsonProperty("heatingZoneId")]
        public string HeatingZoneId { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("nextTargetLevel")]
        public string NextTargetLevel { get; set; }

        [JsonProperty("nextTargetLevelTimestamp")]
        public string NextTargetLevelTimestamp { get; set; }

        [JsonProperty("supportedModes")]
        public string SupportedModes { get; set; }

        [JsonProperty("targetLevel")]
        public string TargetLevel { get; set; }

        [JsonProperty("targetLevelTimestamp")]
        public string TargetLevelTimestamp { get; set; }

        [JsonProperty("thermostatState")]
        public string ThermostatState { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("switchAllMode")]
        public string SwitchAllMode { get; set; }
    }
}