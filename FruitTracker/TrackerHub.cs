using Microsoft.AspNet.SignalR;

namespace FruitTracker {
    public class TrackerHub : Hub {
        public void UpdateBroadcastView() {
            TrackerManager.Instance.RequestUpdate();
        }
    }
}
