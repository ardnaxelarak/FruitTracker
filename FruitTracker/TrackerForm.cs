using ALttPREffectProcessor;
using FruitTracker.Properties;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FruitTracker {
    public partial class TrackerForm : Form {
        private static readonly int PORT = 5777;

        private readonly SnesController snes;
        private CancellationTokenSource snesToken = new();
        private CancellationTokenSource mainToken = new();

        private readonly MapPanel lightWorldMap;
        private readonly MapPanel darkWorldMap;

        private readonly IconSelector entranceSelector;
        private readonly IconSelector dropdownSelector;
        private readonly IconSelector itemSelector;
        private readonly IconSelector annotationDisplay;
        private readonly IconSelector annotationSelector;
        private readonly List<IconSelector> selectors = new();

        private IconList iconList = new();
        private MapIcon? selectedIcon;
        private MapIcon? hoverIcon;

        private Dictionary<string, int> remainingEntrances = new();
        private Dictionary<string, int> remainingDropdowns = new();

        private bool autoTracking = false;
        private bool trackEntrances = false;
        private bool doorShuffle = false;

        private Position popupPosition;
        private Position annotationPosition;

        private dynamic? tracker;

        public TrackerForm() {
            InitializeComponent();

            entranceSelector = new() {
                Visible = false,
            };
            entranceSelector.OnIconClicked += EntranceSelectorIconClicked;
            selectors.Add(entranceSelector);
            Controls.Add(entranceSelector);

            dropdownSelector = new() {
                Visible = false,
            };
            dropdownSelector.OnIconClicked += DropdownSelectorIconClicked;
            selectors.Add(dropdownSelector);
            Controls.Add(dropdownSelector);

            itemSelector = new() {
                Visible = false,
            };
            itemSelector.OnIconClicked += ItemSelectorIconClicked;
            selectors.Add(itemSelector);
            Controls.Add(itemSelector);

            annotationDisplay = new() {
                Visible = false,
                SingleRow = true,
                BackColor = Color.DarkGray,
            };
            annotationDisplay.OnIconClicked += AnnotationDisplayIconClicked;
            selectors.Add(annotationDisplay);
            Controls.Add(annotationDisplay);

            annotationSelector = new() {
                Visible = false,
                BackColor = Color.DarkGray,
            };
            annotationSelector.OnIconClicked += AnnotationSelectorIconClicked;
            selectors.Add(annotationSelector);
            Controls.Add(annotationSelector);


            lightWorldMap = new() {
                MapImage = Resources.LightWorld,
            };
            lightWorldPanel.Controls.Add(lightWorldMap);

            darkWorldMap = new() {
                MapImage = Resources.DarkWorld,
            };
            darkWorldPanel.Controls.Add(darkWorldMap);

            ResizeMapPanels();

            lightWorldMap.OnMapIconSelect += MapIconClicked;
            lightWorldMap.OnMapIconDeselect += MapIconDeselect;
            lightWorldMap.OnMapIconHover += MapIconHover;
            lightWorldMap.OnMapIconExit += MapIconExit;

            darkWorldMap.OnMapIconSelect += MapIconClicked;
            darkWorldMap.OnMapIconDeselect += MapIconDeselect;
            darkWorldMap.OnMapIconHover += MapIconHover;
            darkWorldMap.OnMapIconExit += MapIconExit;

            LoadLayout("Resources/locations_items.yml", "Resources/icons.yml");

            snes = SnesController.Instance;
            inventoryTable1.SetAutoTracker(snes.GetTracking());
            dungeonTable1.SetAutoTracker(snes.GetTracking());
            TrackerManager.Instance.Tracking = snes.GetTracking();
            snes.GetTracking().OnReceiveUpdate += AutoUpdateMapIcons;
            dungeonTable1.ResetCheckCounts();
        }

        private void AutoUpdateMapIcons() {
            lightWorldMap.Locations.ForEach(location => location.CheckAuto());
            darkWorldMap.Locations.ForEach(location => location.CheckAuto());
        }

        private void TrackerForm_Load(object sender, EventArgs e) {
            snes.OnConnected += () => Invoke(new Action(() => autoTrackingLabel.Image = autoTracking ? Resources.green_snes : Resources.gray_snes));
            snes.OnDisconnected += () => Invoke(new Action(() => autoTrackingLabel.Image = autoTracking ? Resources.red_snes : Resources.gray_snes));

            _ = RunWebserver(mainToken.Token);
        }

        private void LoadLayout(string locations, string icons) {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            World world;
            using (StreamReader reader = new(locations)) {
                world = deserializer.Deserialize<World>(reader);
            }

            using (StreamReader reader = new(icons)) {
                iconList = deserializer.Deserialize<IconList>(reader);
            }

            remainingEntrances = iconList.Entrance.ToDictionary(icon => icon.Filename, icon => icon.Count);
            remainingDropdowns = iconList.Dropdown.ToDictionary(icon => icon.Filename, icon => icon.Count);

            lightWorldMap.Locations.Clear();
            lightWorldMap.Locations.AddRange(world.Light.Select(CreateMapIcon).ToList());
            darkWorldMap.Locations.Clear();
            darkWorldMap.Locations.AddRange(world.Dark.Select(CreateMapIcon).ToList());
        }

        private void MapIconHover(MapIcon icon, Point screenPoint) {
            if (selectedIcon == null && hoverIcon != icon) {
                if (icon != null && icon.Annotations.Count > 0) {
                    annotationDisplay.ShowIcons(icon.Annotations);
                    Point clientPoint = PointToClient(screenPoint);
                    Position pos = Position.FromContainer(clientPoint, this, false);
                    pos.SetLocation(annotationDisplay);
                    annotationDisplay.Visible = true;
                } else {
                    annotationDisplay.Visible = false;
                }
                hoverIcon = icon;
            }
        }

        private void MapIconExit() {
            if (selectedIcon == null) {
                annotationDisplay.Visible = false;
                hoverIcon = null;
            }
        }

        private void MapIconClicked(MouseButtons button, MapIcon icon, Point screenPoint) {
            switch (button) {
                case MouseButtons.Left:
                    MapIconLeftClicked(icon, screenPoint);
                    break;
                case MouseButtons.Right:
                    MapIconRightClicked(icon, screenPoint);
                    break;
                case MouseButtons.Middle:
                    MapIconMiddleClicked(icon, screenPoint);
                    break;
            }
        }

        private void MapIconLeftClicked(MapIcon icon, Point screenPoint) {
            selectedIcon = icon;
            hoverIcon = null;
            Point clientPoint = PointToClient(screenPoint);
            selectors.ForEach(selector => { selector.Visible = false; });

            IconSelector? selector = null;

            switch (icon.Type) {
                case LocationType.Entrance:
                    selector = entranceSelector;
                    selector.ShowIcons(iconList.Entrance.Where(
                            icon => remainingEntrances.ContainsKey(icon.Filename) && remainingEntrances[icon.Filename] > 0)
                        .ToList());
                    break;
                case LocationType.Dropdown:
                    selector = dropdownSelector;
                    selector.ShowIcons(iconList.Dropdown.Where(
                            icon => remainingDropdowns.ContainsKey(icon.Filename) && remainingDropdowns[icon.Filename] > 0)
                        .ToList());
                    break;
                case LocationType.Item:
                    selector = itemSelector;
                    selector.ShowIcons(iconList.Item);
                    break;
            }

            if (selector != null) {
                popupPosition = Position.FromContainer(clientPoint, this, false);
                popupPosition.SetLocation(selector);
                selector.Visible = true;

                annotationDisplay.ShowIcons(icon.Annotations.Append(new() { Filename = "plus" }).ToList());
                annotationPosition = Position.FromContainer(clientPoint, this, true);
                annotationPosition.SetLocation(annotationDisplay);
                annotationDisplay.Visible = true;
            }
        }

        private void MapIconRightClicked(MapIcon icon, Point screenPoint) {
            if (icon.Cleared) {
                icon.Cleared = false;
                UpdateIcon(icon);
                selectors.ForEach(selector => { selector.Visible = false; });
            } else {
                icon.Cleared = true;
                icon.ManuallyUpdated = true;
                UpdateIcon(icon);
                selectors.ForEach(selector => { selector.Visible = false; });
            }
        }

        private void MapIconMiddleClicked(MapIcon icon, Point screenPoint) {
            if (icon.DisplayIcon != null) {
                if (icon.Type == LocationType.Entrance) {
                    remainingEntrances[icon.DisplayIcon.Filename] += 1;
                } else if (icon.Type == LocationType.Dropdown) {
                    remainingDropdowns[icon.DisplayIcon.Filename] += 1;
                }
            }
            icon.Reset();
            UpdateIcon(icon);
            selectors.ForEach(selector => { selector.Visible = false; });
            hoverIcon = null;
        }

        private void UpdateIcon(MapIcon icon) {
            lightWorldMap.UpdateIcon(icon);
            darkWorldMap.UpdateIcon(icon);
        }

        private void MapIconDeselect() {
            selectedIcon = null;
            selectors.ForEach(selector => { selector.Visible = false; });
        }

        private void EntranceSelectorIconClicked(Icon icon) {
            if (selectedIcon != null) {
                if (selectedIcon.DisplayIcon != null) {
                    remainingEntrances[selectedIcon.DisplayIcon.Filename] += 1;
                }
                selectedIcon.DisplayIcon = icon;
                remainingEntrances[icon.Filename] -= 1;
                entranceSelector.Visible = false;
                annotationDisplay.Visible = false;

                UpdateIcon(selectedIcon);
                selectedIcon = null;
            }
        }

        private void DropdownSelectorIconClicked(Icon icon) {
            if (selectedIcon != null) {
                if (selectedIcon.DisplayIcon != null) {
                    remainingDropdowns[selectedIcon.DisplayIcon.Filename] += 1;
                }
                selectedIcon.DisplayIcon = icon;
                remainingDropdowns[icon.Filename] -= 1;
                dropdownSelector.Visible = false;
                annotationDisplay.Visible = false;

                UpdateIcon(selectedIcon);
                selectedIcon = null;
            }
        }

        private void ItemSelectorIconClicked(Icon icon) {
            if (selectedIcon != null) {
                selectedIcon.DisplayIcon = icon;
                itemSelector.Visible = false;
                annotationDisplay.Visible = false;

                UpdateIcon(selectedIcon);
                selectedIcon = null;
            }
        }

        private void AnnotationDisplayIconClicked(Icon icon) {
            if (selectedIcon != null) {
                if (icon.Filename == "plus") {
                    itemSelector.Visible = false;
                    entranceSelector.Visible = false;
                    dropdownSelector.Visible = false;
                    annotationSelector.ShowIcons(iconList.Item);
                    popupPosition.SetLocation(annotationSelector);
                    annotationSelector.Visible = true;
                } else {
                    selectedIcon.Annotations.Remove(icon);

                    annotationDisplay.ShowIcons(selectedIcon.Annotations.Append(new() { Filename = "plus" }).ToList());
                    annotationPosition.SetLocation(annotationDisplay);

                    UpdateIcon(selectedIcon);
                }
            }
        }

        private void AnnotationSelectorIconClicked(Icon icon) {
            if (selectedIcon != null) {
                selectedIcon.Annotations.Add(icon);

                annotationDisplay.ShowIcons(selectedIcon.Annotations.Append(new() { Filename = "plus" }).ToList());
                annotationPosition.SetLocation(annotationDisplay);

                UpdateIcon(selectedIcon);
            }
        }

        private MapIcon CreateMapIcon(Location loc) {
            MapIcon newIcon = new() {
                X = loc.X,
                Y = 1 - loc.Y,
                Cleared = false,
                ManuallyUpdated = false,
                Type = loc.Type,
                Memory = loc.Memory,
            };

            newIcon.OnClearedUpdate += UpdateIcon;
            return newIcon;
        }

        private int GetMapSize() {
            int light = Math.Min(lightWorldPanel.Width, lightWorldPanel.Height);
            int dark = Math.Min(darkWorldPanel.Width, darkWorldPanel.Height);
            return Math.Min(light, dark);
        }

        private void ResizeMapPanels() {
            int size = GetMapSize();

            if (lightWorldMap != null) {
                lightWorldMap.Size = new(size, size);
                lightWorldMap.Left = lightWorldPanel.Right - size;
                lightWorldMap.Refresh();
            }

            if (darkWorldMap != null) {
                darkWorldMap.Size = new(size, size);
                darkWorldMap.Refresh();
            }
        }

        private void MapPanel_SizeChanged(object sender, EventArgs e) {
            ResizeMapPanels();
        }

        private void modeLabel_Click(object sender, EventArgs e) {
            if (trackEntrances) {
                trackEntrances = false;
                LoadLayout("Resources/locations_items.yml", "Resources/icons.yml");
                entranceLabel.Image = Resources.bow;
                lightWorldMap.Refresh();
                darkWorldMap.Refresh();
            } else {
                trackEntrances = true;
                if (doorShuffle) {
                    LoadLayout("Resources/locations.yml", "Resources/icons_doors.yml");
                } else {
                    LoadLayout("Resources/locations.yml", "Resources/icons.yml");
                }
                entranceLabel.Image = Resources.entrance;
                lightWorldMap.Refresh();
                darkWorldMap.Refresh();
            }
        }

        private void doorsLabel_Click(object sender, EventArgs e) {
            if (doorShuffle) {
                doorShuffle = false;
                if (trackEntrances) {
                    LoadLayout("Resources/locations.yml", "Resources/icons.yml");
                }
                doorsLabel.Image = Resources.open_door;
                lightWorldMap.Refresh();
                darkWorldMap.Refresh();
            } else {
                doorShuffle = true;
                if (trackEntrances) {
                    LoadLayout("Resources/locations.yml", "Resources/icons_doors.yml");
                }
                doorsLabel.Image = Resources.locked_door;
                lightWorldMap.Refresh();
                darkWorldMap.Refresh();
            }
            dungeonTable1.DoorShuffle = doorShuffle;
        }

        private async void autoTrackingLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                autoTracking = true;
                autoTrackingLabel.Image = Resources.red_snes;
                if (!snes.Connected) {
                    await snes.Connect();
                    snesToken.Cancel();
                    snesToken = new();
                    _ = snes.Main(snesToken.Token);
                }
            } else if (e.Button == MouseButtons.Right) {
                autoTracking = false;
                autoTrackingLabel.Image = Resources.gray_snes;
                snesToken.Cancel();
                snesToken = new();
            }
        }

        private async Task RunWebserver(CancellationToken token) {
            string baseUrl = $"http://localhost:{PORT}/";
            using (WebApp.Start<WebServer>(baseUrl)) {
                TrackerManager.Instance.Tracker = GlobalHost.ConnectionManager.GetHubContext<TrackerHub>().Clients.All;
                TrackerManager.Instance.OnRequestUpdate += () => {
                    inventoryTable1.UpdateBroadcastView();
                    dungeonTable1.UpdateBroadcastView();
                };
                while (!token.IsCancellationRequested) {
                    try {
                        await Task.Delay(TimeSpan.FromSeconds(0.05), token);
                    } catch (TaskCanceledException) { }
                }
            }
        }

        private void mapShuffleLabel_MouseDown(object sender, MouseEventArgs e) {
            dungeonTable1.ShuffleMaps = !dungeonTable1.ShuffleMaps;
            mapShuffleLabel.Image = dungeonTable1.ShuffleMaps ? Inventory.map : Inventory.no_map;
            dungeonTable1.UpdateMaxCheckCounts();
        }

        private void compassShuffleLabel_MouseDown(object sender, MouseEventArgs e) {
            dungeonTable1.ShuffleCompasses = !dungeonTable1.ShuffleCompasses;
            compassShuffleLabel.Image = dungeonTable1.ShuffleCompasses ? Inventory.compass : Inventory.no_compass;
            dungeonTable1.UpdateMaxCheckCounts();
        }

        private void bigKeyShuffleLabel_MouseDown(object sender, MouseEventArgs e) {
            dungeonTable1.ShuffleBigKeys = !dungeonTable1.ShuffleBigKeys;
            bigKeyShuffleLabel.Image = dungeonTable1.ShuffleBigKeys ? Inventory.bigkey : Inventory.no_bigkey;
            dungeonTable1.UpdateMaxCheckCounts();
        }

        private void smallKeyShuffleLabel_MouseDown(object sender, MouseEventArgs e) {
            dungeonTable1.ShuffleSmallKeys = !dungeonTable1.ShuffleSmallKeys;
            smallKeyShuffleLabel.Image = dungeonTable1.ShuffleSmallKeys ? Inventory.smallkey : Inventory.no_smallkey;
            dungeonTable1.UpdateMaxCheckCounts();
        }

        private void resetIcon_Click(object sender, EventArgs e) {
            if (autoTracking) {
                autoTracking = false;
                autoTrackingLabel.Image = Resources.gray_snes;
                snesToken.Cancel();
                snesToken = new();
            }
            dungeonTable1.ResetMaxCheckCounts();
            dungeonTable1.ResetCheckCounts();
            dungeonTable1.ResetKeyCounts();
            dungeonTable1.ResetDungeonItems();
            inventoryTable1.ResetInventory();
            if (!trackEntrances) {
                LoadLayout("Resources/locations_items.yml", "Resources/icons.yml");
            } else if (doorShuffle) {
                LoadLayout("Resources/locations.yml", "Resources/icons_doors.yml");
            } else {
                LoadLayout("Resources/locations.yml", "Resources/icons.yml");
            }
            lightWorldMap.Refresh();
            darkWorldMap.Refresh();
        }
    }
}