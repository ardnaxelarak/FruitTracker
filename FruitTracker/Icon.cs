namespace FruitTracker {
    public class Icon {
        public string Filename { get; set; } = "";
        public string? Name { get; set; }
        public int Count { get; set; }
        public string? Group { get; set; }
        public string? Overlay { get; set; }

        public string? GroupOrName {
            get => Group ?? Filename;
        }
    }
}
