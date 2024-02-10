using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace FruitTracker {
    public class IconManager {
        private static IconManager? instance;

        private readonly Dictionary<string, Image> images = new();

        public static IconManager Instance {
            get {
                instance ??= new();
                return instance;
            }
        }

        public Image GetImage(string name) {
            if (!images.ContainsKey(name)) {
                try {
                    images[name] = Image.FromFile("Assets/icons/" + name + ".png");
                } catch (FileNotFoundException ex) {
                    return new Bitmap(24, 24);
                }
            }
            return images[name];
        }

        public Image? this[string name] => GetImage(name);
    }
}
