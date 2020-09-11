using System;
using RokuDataObjects;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace RokuAccess
{
    public class XMLSerialize
    {
        public static RokuDeviceInfo DeserializeRokuDeviceInfo(string details)
        {
            var serializer = new XmlSerializer(typeof(RokuDeviceInfo));
            var rdr = new StringReader(details);
            return (RokuDeviceInfo)serializer.Deserialize(rdr);
        }

        public static List<RokuApp> DeserializeApps(string details)
        {
            var serializer = new XmlSerializer(typeof(RokuApps));
            var rdr = new StringReader(details);
            var deserializedObject = (RokuApps)serializer.Deserialize(rdr);
            return deserializedObject.App;
        }
    }
}
