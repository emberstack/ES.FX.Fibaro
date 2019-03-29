using System;

namespace ES.FX.Fibaro
{
    public static class SmartDeviceExtensions
    {
        public static bool IsFibaroDeviceId(this string value)
        {
            return !string.IsNullOrWhiteSpace(value) && value.StartsWith($"{SmartDevice.Provider}:");
        }

        public static long GetSmartDeviceId(this string value)
        {
            if (!value.IsFibaroDeviceId())
                throw new ArgumentException("Value is not a valid Fibaro Home Controller ID.", nameof(value));
            return long.Parse(value.Replace($"{SmartDevice.Provider}:", string.Empty));
        }
    }
}