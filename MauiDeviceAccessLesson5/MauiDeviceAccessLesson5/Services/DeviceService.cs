using System;
using System.Collections.Generic;
using System.Text;

namespace MauiDeviceAccessLesson5.Services
{
    internal class DeviceService
    {
        public string GetModel() => DeviceInfo.Model;

        public string GetManufacturer() => DeviceInfo.Manufacturer;

        public string GetOsVersion() => DeviceInfo.VersionString;

        public int? GetBatteryLevel()
        {
            var charge = Battery.ChargeLevel;
            if (charge < 0)
                return null;
            return (int)(charge * 100.00);
        }

        public string GetPowerSource()
        {
            return Battery.PowerSource.ToString();
        }
    }
}
