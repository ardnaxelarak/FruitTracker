using System.Collections.Generic;

namespace FruitTracker {
    public class World {
        public List<Location> Light { get; set; } = new();
        public List<Location> Dark { get; set; } = new();
    }
}
