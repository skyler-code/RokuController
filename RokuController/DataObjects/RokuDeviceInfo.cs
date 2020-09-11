using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace RokuDataObjects
{
	[XmlRoot(ElementName = "device-info")]
	public class RokuDeviceInfo
	{
		[XmlElement(ElementName = "udn")]
		public string Udn { get; set; }
		[XmlElement(ElementName = "serial-number")]
		public string Serialnumber { get; set; }
		[XmlElement(ElementName = "device-id")]
		public string Deviceid { get; set; }
		[XmlElement(ElementName = "advertising-id")]
		public string Advertisingid { get; set; }
		[XmlElement(ElementName = "vendor-name")]
		public string Vendorname { get; set; }
		[XmlElement(ElementName = "model-name")]
		public string Modelname { get; set; }
		[XmlElement(ElementName = "model-number")]
		public string Modelnumber { get; set; }
		[XmlElement(ElementName = "model-region")]
		public string Modelregion { get; set; }
		[XmlElement(ElementName = "is-tv")]
		public string Istv { get; set; }
		[XmlElement(ElementName = "is-stick")]
		public string Isstick { get; set; }
		[XmlElement(ElementName = "screen-size")]
		public string Screensize { get; set; }
		[XmlElement(ElementName = "panel-id")]
		public string Panelid { get; set; }
		[XmlElement(ElementName = "tuner-type")]
		public string Tunertype { get; set; }
		[XmlElement(ElementName = "supports-ethernet")]
		public string Supportsethernet { get; set; }
		[XmlElement(ElementName = "wifi-mac")]
		public string Wifimac { get; set; }
		[XmlElement(ElementName = "wifi-driver")]
		public string Wifidriver { get; set; }
		[XmlElement(ElementName = "has-wifi-extender")]
		public string Haswifiextender { get; set; }
		[XmlElement(ElementName = "has-wifi-5G-support")]
		public string Haswifi5Gsupport { get; set; }
		[XmlElement(ElementName = "can-use-wifi-extender")]
		public string Canusewifiextender { get; set; }
		[XmlElement(ElementName = "ethernet-mac")]
		public string Ethernetmac { get; set; }
		[XmlElement(ElementName = "network-type")]
		public string Networktype { get; set; }
		[XmlElement(ElementName = "friendly-device-name")]
		public string Friendlydevicename { get; set; }
		[XmlElement(ElementName = "friendly-model-name")]
		public string Friendlymodelname { get; set; }
		[XmlElement(ElementName = "default-device-name")]
		public string Defaultdevicename { get; set; }
		[XmlElement(ElementName = "user-device-name")]
		public string Userdevicename { get; set; }
		[XmlElement(ElementName = "user-device-location")]
		public string Userdevicelocation { get; set; }
		[XmlElement(ElementName = "build-number")]
		public string Buildnumber { get; set; }
		[XmlElement(ElementName = "software-version")]
		public string Softwareversion { get; set; }
		[XmlElement(ElementName = "software-build")]
		public string Softwarebuild { get; set; }
		[XmlElement(ElementName = "secure-device")]
		public string Securedevice { get; set; }
		[XmlElement(ElementName = "language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "country")]
		public string Country { get; set; }
		[XmlElement(ElementName = "locale")]
		public string Locale { get; set; }
		[XmlElement(ElementName = "time-zone-auto")]
		public string Timezoneauto { get; set; }
		[XmlElement(ElementName = "time-zone")]
		public string Timezone { get; set; }
		[XmlElement(ElementName = "time-zone-name")]
		public string Timezonename { get; set; }
		[XmlElement(ElementName = "time-zone-tz")]
		public string Timezonetz { get; set; }
		[XmlElement(ElementName = "time-zone-offset")]
		public string Timezoneoffset { get; set; }
		[XmlElement(ElementName = "clock-format")]
		public string Clockformat { get; set; }
		[XmlElement(ElementName = "uptime")]
		public string Uptime { get; set; }
		[XmlElement(ElementName = "power-mode")]
		public string Powermode { get; set; }
		[XmlElement(ElementName = "supports-suspend")]
		public string Supportssuspend { get; set; }
		[XmlElement(ElementName = "supports-find-remote")]
		public string Supportsfindremote { get; set; }
		[XmlElement(ElementName = "supports-audio-guide")]
		public string Supportsaudioguide { get; set; }
		[XmlElement(ElementName = "supports-rva")]
		public string Supportsrva { get; set; }
		[XmlElement(ElementName = "developer-enabled")]
		public string Developerenabled { get; set; }
		[XmlElement(ElementName = "keyed-developer-id")]
		public string Keyeddeveloperid { get; set; }
		[XmlElement(ElementName = "search-enabled")]
		public string Searchenabled { get; set; }
		[XmlElement(ElementName = "search-channels-enabled")]
		public string Searchchannelsenabled { get; set; }
		[XmlElement(ElementName = "voice-search-enabled")]
		public string Voicesearchenabled { get; set; }
		[XmlElement(ElementName = "notifications-enabled")]
		public string Notificationsenabled { get; set; }
		[XmlElement(ElementName = "notifications-first-use")]
		public string Notificationsfirstuse { get; set; }
		[XmlElement(ElementName = "supports-private-listening")]
		public string Supportsprivatelistening { get; set; }
		[XmlElement(ElementName = "supports-private-listening-dtv")]
		public string Supportsprivatelisteningdtv { get; set; }
		[XmlElement(ElementName = "supports-warm-standby")]
		public string Supportswarmstandby { get; set; }
		[XmlElement(ElementName = "headphones-connected")]
		public string Headphonesconnected { get; set; }
		[XmlElement(ElementName = "supports-ecs-textedit")]
		public string Supportsecstextedit { get; set; }
		[XmlElement(ElementName = "supports-ecs-microphone")]
		public string Supportsecsmicrophone { get; set; }
		[XmlElement(ElementName = "supports-wake-on-wlan")]
		public string Supportswakeonwlan { get; set; }
		[XmlElement(ElementName = "has-play-on-roku")]
		public string Hasplayonroku { get; set; }
		[XmlElement(ElementName = "has-mobile-screensaver")]
		public string Hasmobilescreensaver { get; set; }
		[XmlElement(ElementName = "support-url")]
		public string Supporturl { get; set; }
		[XmlElement(ElementName = "grandcentral-version")]
		public string Grandcentralversion { get; set; }
		[XmlElement(ElementName = "davinci-version")]
		public string Davinciversion { get; set; }
	}

}