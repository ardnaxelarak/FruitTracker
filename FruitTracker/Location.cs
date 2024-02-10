using System.Collections.Generic;

namespace FruitTracker {
    public class Location {
        public string? Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public LocationType Type { get; set; }
        public List<MemoryValue> Memory { get; set; } = new();
    }

    public enum LocationType {
        Entrance,
        Dropdown,
        DropdownEntrance,
        Item,
        Exit,
    }

    public class MemoryValue {
        public int Address { get; set; }
        public byte Mask { get; set; }
    }
}
