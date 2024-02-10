using ALttPREffectProcessor;
using System;

namespace FruitTracker {
    internal class TrackerManager {
        private static TrackerManager? instance;

        public static TrackerManager Instance {
            get {
                instance ??= new();
                return instance;
            }
        }

        public dynamic? Tracker { get; set; }

        public Tracking? Tracking { get; set; }

        public void RequestUpdate() {
            OnRequestUpdate?.Invoke();
        }

        public event Action? OnRequestUpdate;
    }
}
