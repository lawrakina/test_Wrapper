using System.Collections.Generic;
using AppsFlyerSDK;
using UnityEngine;


namespace Code.Integrations {
    public class AppsFlyerObjectScript : MonoBehaviour, IAppsFlyerConversionData {
        public string DevKey = "a9BYgLcs5YwNr6aYYz9WA3";
        public string AppId = "com.lawrapps.RunWrap";
        public void Start() {
            AppsFlyer.setIsDebug(true);
            AppsFlyer.initSDK(DevKey, "", this);
            AppsFlyer.startSDK();
        }

        public void onConversionDataSuccess(string conversionData) {
            AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
            Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
            // add deferred deeplink logic here
        }

        public void onConversionDataFail(string error) {
            AppsFlyer.AFLog("onConversionDataFail", error);
        }

        public void onAppOpenAttribution(string attributionData) {
            AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
            Dictionary<string, object> attributionDataDictionary =
                AppsFlyer.CallbackStringToDictionary(attributionData);
            // add direct deeplink logic here
        }

        public void onAppOpenAttributionFailure(string error) {
            AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
        }
    }
}