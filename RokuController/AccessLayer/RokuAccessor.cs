using RokuDataObjects;
using System.Collections.Generic;
using Rssdp;
using System.Text.RegularExpressions;
using System;
using System.Net;
using System.Web;
using System.Threading.Tasks;

namespace RokuAccess
{
    public class RokuAccessor
    {
        public static List<Roku> GetRokuList()
        {
            var deviceLocator = new SsdpDeviceLocator();
            var ipRegex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            var foundDevices = deviceLocator.SearchAsync("roku:ecp").Result;
            var rokus = new List<Roku>();
            foreach (var device in foundDevices)
            {
                var deviceUrl = device.DescriptionLocation.ToString();
                var detailsUrl = deviceUrl + "query/device-info";
                var appsUrl = deviceUrl + "query/apps";
                var result = ipRegex.Matches(deviceUrl);
                var ipAddress = IPAddress.Parse(result[0].ToString());
                var details = HTTPTools.Get(detailsUrl);
                var appDetails = HTTPTools.Get(appsUrl);
                var rokuInfo = XMLSerialize.DeserializeRokuDeviceInfo(details);
                var rokuApps = XMLSerialize.DeserializeApps(appDetails).FindAll( a => a.Id != ((int)RokuAppIds.Fandango).ToString());
                var deviceName = rokuInfo.Friendlydevicename;
                var displayName = String.Format("{0} ({1})", deviceName, ipAddress);
                rokus.Add(new Roku { Url = deviceUrl, DeviceName = deviceName, IPAddress = ipAddress, DisplayName = displayName, Apps = rokuApps });
            }
            return rokus;
        }

        public static void SendRokuButton(Roku roku, KeyCode keyCode)
        {
            var sendKeyUrl = roku.Url + "keypress/" + keyCode;
            _ = HTTPTools.PostAsync(sendKeyUrl);
        }

        public static void LaunchRokuApp(Roku roku, RokuApp app)
        {
            var launchUrl = roku.Url + "launch/" + app.Id;
            _ = HTTPTools.PostAsync(launchUrl);
        }

        public static Task SendRokuManualKeyEntryAsync(Roku roku, char key)
        {
            var encodedKey = HttpUtility.UrlEncode(key.ToString());
            var sendKeyUrl = roku.Url + "keypress/Lit_" + encodedKey;
            return HTTPTools.PostAsync(sendKeyUrl);
        }
    }
}
