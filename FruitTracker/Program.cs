using System;
using System.Windows.Forms;

namespace FruitTracker {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.Run(new TrackerForm());
        }
    }
}