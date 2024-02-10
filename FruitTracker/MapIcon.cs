using ALttPREffectProcessor;
using System;
using System.Collections.Generic;

namespace FruitTracker {
    public class MapIcon {
        public float X { get; set; }
        public float Y { get; set; }

        public Icon? DisplayIcon { get; set; }

        public LocationType Type { get; set; }

        private bool cleared;

        public bool Cleared {
            get => cleared;
            set {
                if (cleared != value) {
                    cleared = value;
                    OnClearedUpdate?.Invoke(this);
                }
            }
        }
        public bool ManuallyUpdated { get; set; }

        public event Action<MapIcon>? OnClearedUpdate;

        public List<MemoryValue> Memory { get; set; } = new();

        public void Reset() {
            DisplayIcon = null;
            Cleared = false;
            ManuallyUpdated = false;
        }

        public void CheckAuto() {
            Tracking? tr = TrackerManager.Instance.Tracking;
            if (tr is null || ManuallyUpdated || Memory.Count == 0) return;

            bool fullCleared = true;
            foreach (MemoryValue mem in Memory) {
                try {
                    if ((tr.GetWramByte(mem.Address) & mem.Mask) == 0) {
                        fullCleared = false;
                    }
                } catch (MemoryNotCachedException) {
                    return;
                }
            }

            if (fullCleared != Cleared) {
                Cleared = fullCleared;
            }
        }
    }
}
