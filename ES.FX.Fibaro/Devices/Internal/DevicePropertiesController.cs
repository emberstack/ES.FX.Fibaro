using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using ES.FX.Fibaro.Devices.Internal.Models;
using ES.FX.Fibaro.Devices.Models;
using Newtonsoft.Json.Linq;

namespace ES.FX.Fibaro.Devices.Internal
{
    internal class DevicePropertiesController : IDevicePropertiesController
    {
        private ExpandoObject _properties;

        internal JObject PropertiesJObject
        {
            set
            {
                _properties = value.ToObject<ExpandoObject>();
                Managed = value.ToObject<DevicePropertiesModel>();
            }
        }


        private IDictionary<string, object> PropertiesDictionary => _properties;

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return PropertiesDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return PropertiesDictionary.GetEnumerator();
        }

        public int Count => PropertiesDictionary.Count;

        public bool ContainsKey(string key)
        {
            return PropertiesDictionary.ContainsKey(key);
        }

        public bool TryGetValue(string key, out object value)
        {
            return PropertiesDictionary.TryGetValue(key, out value);
        }

        public object this[string key] => PropertiesDictionary[key];
        public IEnumerable<string> Keys => PropertiesDictionary.Keys;
        public IEnumerable<object> Values => PropertiesDictionary.Values;


        public dynamic Dynamic => _properties;

        public IDevicePropertiesModel Managed { get; private set; }
    }
}