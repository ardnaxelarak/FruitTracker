using System.Threading.Tasks;

namespace FruitTracker {
    public interface ITrackingClient {
        Task StartClock();
        Task StopClock();
        Task ResetClock(int millis = 0);
        Task UpdateItem(string cellId, string[] images);
        Task UpdateBigKey(string dungeonId, bool hasKey);
        Task UpdateKeys(string dungeonId, int keyCount, bool hasAllKeys);
        Task UpdateDungeonPrize(string dungeonId, string dungeonImage, string prizeImage);
    }

    internal class DummyTrackingClient : ITrackingClient {
        public Task StartClock() => Task.CompletedTask;
        public Task StopClock() => Task.CompletedTask;
        public Task ResetClock(int millis = 0) => Task.CompletedTask;
        public Task UpdateItem(string cellId, string[] images) => Task.CompletedTask;
        public Task UpdateBigKey(string dungeonId, bool hasKey) => Task.CompletedTask;
        public Task UpdateKeys(string dungeonId, int keyCount, bool hasAllKeys) => Task.CompletedTask;
        public Task UpdateDungeonPrize(string dungeonId, string dungeonImage, string prizeImage) => Task.CompletedTask;
    }
}
