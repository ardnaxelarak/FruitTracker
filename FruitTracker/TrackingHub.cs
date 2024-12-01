using Microsoft.AspNetCore.SignalR;

namespace FruitTracker {
    public class TrackingHub : Hub<ITrackingClient> { }
}
