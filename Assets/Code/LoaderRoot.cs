using System;
using AppsFlyerSDK;
using Code.Base;
using UnityEngine;


namespace Code {
    public class LoaderRoot : MonoBehaviour {
        [SerializeField] private AppsFlyerSettings _appsFlyerSettings;
        [SerializeField] private Integrations.AppsFlyerObjectScript _appsFlyerObjectScript;
        [SerializeField] private LoadingView _loadingView;


        #region PrivateData

        private Controllers _controllers;

        #endregion


        private void Awake() {
            // _appsFlyerObjectScript.Init(_appsFlyerSettings.DevKey, _appsFlyerSettings.AppId);
            
            _controllers = new Controllers();

            var networkDataBus = new NetworkDataBus();
            // var networkController = new NetworkController(networkDataBus, _settings);
        }

        private void OnEnable() {
            _controllers.Start();
        }

        private void Update() {
            _controllers.Execute(Time.deltaTime);
        }

        private void FixedUpdate() {
            _controllers.FixedExecute(Time.deltaTime);
        }

        private void OnDisable() {
            _controllers.ClearUp();
        }
    }

    [Serializable]
    internal class AppsFlyerSettings {
        public string DevKey = "a9BYgLcs5YwNr6aYYz9WA3";
        public string AppId = "com.lawrapps.RunWrap";
    }

    internal class NetworkController : IController {
        public NetworkController(NetworkDataBus networkDataBus) {
        }

        public void Start() {
            throw new NotImplementedException();
        }

        public void ClearUp() {
            throw new NotImplementedException();
        }
    }

    internal class NetworkDataBus {
    }
}