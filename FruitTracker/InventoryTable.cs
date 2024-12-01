using ALttPREffectProcessor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FruitTracker {
    public partial class InventoryTable : UserControl {
        private readonly InventoryIcon bowIcon;
        private readonly InventoryIcon boomerangIcon;
        private readonly InventoryIcon hookshotIcon;
        private readonly InventoryIcon bombIcon;
        private readonly InventoryIcon powderIcon;
        private readonly InventoryIcon mushroomIcon;
        private readonly InventoryIcon bootsIcon;
        private readonly InventoryIcon swordIcon;

        private readonly InventoryIcon firerodIcon;
        private readonly InventoryIcon icerodIcon;
        private readonly InventoryIcon bombosIcon;
        private readonly InventoryIcon etherIcon;
        private readonly InventoryIcon quakeIcon;
        private readonly InventoryIcon magicIcon;
        private readonly InventoryIcon gloveIcon;
        private readonly InventoryIcon shieldIcon;

        private readonly InventoryIcon lampIcon;
        private readonly InventoryIcon hammerIcon;
        private readonly InventoryIcon fluteIcon;
        private readonly InventoryIcon netIcon;
        private readonly InventoryIcon bookIcon;
        private readonly InventoryIcon shovelIcon;
        private readonly InventoryIcon flippersIcon;
        private readonly InventoryIcon armorIcon;

        private readonly InventoryIcon bottleIcon;
        private readonly InventoryIcon somariaIcon;
        private readonly InventoryIcon byrnaIcon;
        private readonly InventoryIcon capeIcon;
        private readonly InventoryIcon mirrorIcon;
        private readonly InventoryIcon pearlIcon;
        private readonly EntranceMedallionIcon mmIcon;
        private readonly EntranceMedallionIcon trIcon;

        private readonly List<InventoryIcon> inventoryIcons = new();
        private readonly List<EntranceMedallionIcon> entranceIcons = new();

        private Tracking? tracking;

        private bool tripleGlove = false;
        private bool doubleMirror = false;

        private readonly string[][] mirrorMapItems = new string[][] {
            new [] { "no_mirror" },
            new [] { "map" },
            new [] { "mirror" },
        };
        private readonly string[][] doubleMirrorItems = new string[][] {
            new [] { "no_mirror" },
            new [] { "mirror" },
            new [] { "mirror_2" },
        };
        private readonly string[][] doubleGloveItems = new string[][] {
            new [] { "no_glove" },
            new [] { "glove_1" },
            new [] { "glove_2" },
        };
        private readonly string[][] tripleGloveItems = new string[][] {
            new [] { "no_glove" },
            new [] { "glove_weak" },
            new [] { "glove_1" },
            new [] { "glove_2" },
        };

        public InventoryTable() {
            InitializeComponent();

            bowIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bowCell",
                ImageSets = new string[][] {
                    new [] { "no_bow" },
                    new [] { "bow", "arrow_wooden" },
                    new [] { "no_bow", "arrow_silver" },
                    new [] { "bow", "arrow_silver" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bowIcon, 0, 0);
            inventoryIcons.Add(bowIcon);

            boomerangIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "boomerangCell",
                ImageSets = new string[][] {
                    new [] { "no_boomerangs" },
                    new [] { "no_boomerangs", "boomerang_blue" },
                    new [] { "no_boomerangs", "boomerang_red" },
                    new [] { "boomerang_blue", "boomerang_red" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(boomerangIcon, 1, 0);
			inventoryIcons.Add(boomerangIcon);

            hookshotIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "hookshotCell",
                ImageSets = new string[][] {
                    new [] { "no_hookshot" },
                    new [] { "hookshot" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(hookshotIcon, 2, 0);
			inventoryIcons.Add(hookshotIcon);

            bombIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bombCell",
                ImageSets = new string[][] {
                    new [] { "no_bomb" },
                    new [] { "bomb" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bombIcon, 3, 0);
			inventoryIcons.Add(bombIcon);

            powderIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "powderCell",
                ImageSets = new string[][] {
                    new [] { "no_powder" },
                    new [] { "powder" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(powderIcon, 4, 0);
			inventoryIcons.Add(powderIcon);

            mushroomIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "mushroomCell",
                ImageSets = new string[][] {
                    new [] { "no_mushroom" },
                    new [] { "mushroom" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(mushroomIcon, 5, 0);
			inventoryIcons.Add(mushroomIcon);

            bootsIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bootsCell",
                ImageSets = new string[][] {
                    new [] { "no_boots" },
                    new [] { "boots" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bootsIcon, 6, 0);
			inventoryIcons.Add(bootsIcon);

            swordIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "swordCell",
                ImageSets = new string[][] {
                    new [] { "no_sword" },
                    new [] { "sword_1" },
                    new [] { "sword_2" },
                    new [] { "sword_3" },
                    new [] { "sword_4" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(swordIcon, 7, 0);
			inventoryIcons.Add(swordIcon);

            firerodIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "firerodCell",
                ImageSets = new string[][] {
                    new [] { "no_firerod" },
                    new [] { "firerod" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(firerodIcon, 0, 1);
			inventoryIcons.Add(firerodIcon);

            icerodIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "icerodCell",
                ImageSets = new string[][] {
                    new [] { "no_icerod" },
                    new [] { "icerod" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(icerodIcon, 1, 1);
			inventoryIcons.Add(icerodIcon);

            bombosIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bombosCell",
                ImageSets = new string[][] {
                    new [] { "no_bombos" },
                    new [] { "bombos" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bombosIcon, 2, 1);
			inventoryIcons.Add(bombosIcon);

            etherIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "etherCell",
                ImageSets = new string[][] {
                    new [] { "no_ether" },
                    new [] { "ether" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(etherIcon, 3, 1);
			inventoryIcons.Add(etherIcon);

            quakeIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "quakeCell",
                ImageSets = new string[][] {
                    new [] { "no_quake" },
                    new [] { "quake" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(quakeIcon, 4, 1);
			inventoryIcons.Add(quakeIcon);

            magicIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "magicCell",
                ImageSets = new string[][] {
                    new [] { "no_magic_half" },
                    new [] { "magic_half" },
                    new [] { "magic_quarter" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(magicIcon, 5, 1);
			inventoryIcons.Add(magicIcon);

            gloveIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "gloveCell",
                ImageSets = doubleGloveItems,
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(gloveIcon, 6, 1);
			inventoryIcons.Add(gloveIcon);

            shieldIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "shieldCell",
                ImageSets = new string[][] {
                    new [] { "no_shield" },
                    new [] { "shield_1" },
                    new [] { "shield_2" },
                    new [] { "shield_3" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(shieldIcon, 7, 1);
			inventoryIcons.Add(shieldIcon);

            lampIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "lampCell",
                ImageSets = new string[][] {
                    new [] { "no_lamp" },
                    new [] { "lamp" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(lampIcon, 0, 2);
			inventoryIcons.Add(lampIcon);

            hammerIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "hammerCell",
                ImageSets = new string[][] {
                    new [] { "no_hammer" },
                    new [] { "hammer" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(hammerIcon, 1, 2);
			inventoryIcons.Add(hammerIcon);

            fluteIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "fluteCell",
                ImageSets = new string[][] {
                    new [] { "no_flute" },
                    new [] { "flute", "small-x" },
                    new [] { "flute", "duck" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(fluteIcon, 2, 2);
			inventoryIcons.Add(fluteIcon);

            netIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "netCell",
                ImageSets = new string[][] {
                    new [] { "no_bugnet" },
                    new [] { "bugnet" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(netIcon, 3, 2);
			inventoryIcons.Add(netIcon);

            bookIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bookCell",
                ImageSets = new string[][] {
                    new [] { "no_book" },
                    new [] { "book" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bookIcon, 4, 2);
			inventoryIcons.Add(bookIcon);

            shovelIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "shovelCell",
                ImageSets = new string[][] {
                    new [] { "no_shovel" },
                    new [] { "shovel" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(shovelIcon, 5, 2);
			inventoryIcons.Add(shovelIcon);

            flippersIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "flippersCell",
                ImageSets = new string[][] {
                    new [] { "no_flippers" },
                    new [] { "flippers" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(flippersIcon, 6, 2);
			inventoryIcons.Add(flippersIcon);

            armorIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "armorCell",
                ImageSets = new string[][] {
                    new [] { "tunic_1" },
                    new [] { "tunic_2" },
                    new [] { "tunic_3" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(armorIcon, 7, 2);
			inventoryIcons.Add(armorIcon);

            bottleIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "bottleCell",
                ImageSets = new string[][] {
                    new [] { "no_bottle" },
                    new [] { "bottle_1" },
                    new [] { "bottle_2" },
                    new [] { "bottle_3" },
                    new [] { "bottle_4" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(bottleIcon, 0, 3);
			inventoryIcons.Add(bottleIcon);

            somariaIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "somariaCell",
                ImageSets = new string[][] {
                    new [] { "no_somaria" },
                    new [] { "somaria" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(somariaIcon, 1, 3);
			inventoryIcons.Add(somariaIcon);

            byrnaIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "byrnaCell",
                ImageSets = new string[][] {
                    new [] { "no_byrna" },
                    new [] { "byrna" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(byrnaIcon, 2, 3);
			inventoryIcons.Add(byrnaIcon);

            capeIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "capeCell",
                ImageSets = new string[][] {
                    new [] { "no_cape" },
                    new [] { "cape" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(capeIcon, 3, 3);
			inventoryIcons.Add(capeIcon);

            mirrorIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "mirrorCell",
                ImageSets = mirrorMapItems,
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(mirrorIcon, 4, 3);
			inventoryIcons.Add(mirrorIcon);

            pearlIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "pearlCell",
                ImageSets = new string[][] {
                    new [] { "no_pearl" },
                    new [] { "pearl" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(pearlIcon, 5, 3);
			inventoryIcons.Add(pearlIcon);

            mmIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "mmEntrance",
                ImageSets = new string[][] {
                    new [] { "mm_entrance" },
                    new [] { "bombos_overlay", "mm_entrance" },
                    new [] { "ether_overlay", "mm_entrance" },
                    new [] { "quake_overlay", "mm_entrance" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(mmIcon, 6, 3);
			entranceIcons.Add(mmIcon);

            trIcon = new() {
                BackColor = itemLayoutPanel.BackColor,
                CellId = "trEntrance",
                ImageSets = new string[][] {
                    new [] { "tr_entrance" },
                    new [] { "bombos_overlay", "tr_entrance" },
                    new [] { "ether_overlay", "tr_entrance" },
                    new [] { "quake_overlay", "tr_entrance" },
                },
                Value = 0,
            };
            itemLayoutPanel.Controls.Add(trIcon, 7, 3);
			entranceIcons.Add(trIcon);
        }

        public void SetAutoTracker(Tracking tracking) {
            this.tracking = tracking;
            tracking.OnReceiveUpdate += AutoTrackerUpdate;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool TripleGlove {
            get => tripleGlove;
            set {
                tripleGlove = value;
                gloveIcon.ImageSets = tripleGlove ? tripleGloveItems : doubleGloveItems;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DoubleMirror {
            get => doubleMirror;
            set {
                doubleMirror = value;
                mirrorIcon.ImageSets = doubleMirror ? doubleMirrorItems : mirrorMapItems;
            }
        }

        private void AutoTrackerUpdate() {
            if (tracking == null) {
                return;
            }

            bowIcon.Value = tracking.SilverArrows.Value << 1 | tracking.Bow.Value;
            boomerangIcon.Value = tracking.RedBoomerang.Value << 1 | tracking.BlueBoomerang.Value;
            hookshotIcon.Value = tracking.Hookshot.Value;
            bombIcon.Value = tracking.Bombs.Value;
            powderIcon.Value = tracking.Powder.Value;
            mushroomIcon.Value = tracking.Mushroom.Value;
            bootsIcon.Value = tracking.Boots.Value;
            swordIcon.Value = tracking.Sword.Value;
            firerodIcon.Value = tracking.FireRod.Value;
            icerodIcon.Value = tracking.IceRod.Value;
            bombosIcon.Value = tracking.Bombos.Value;
            etherIcon.Value = tracking.Ether.Value;
            quakeIcon.Value = tracking.Quake.Value;
            magicIcon.Value = tracking.MagicUsage.Value;
            gloveIcon.Value = tracking.Gloves.Value;
            shieldIcon.Value = tracking.Shield.Value;
            lampIcon.Value = tracking.Lamp.Value;
            hammerIcon.Value = tracking.Hammer.Value;
            fluteIcon.Value = tracking.Flute.Value;
            netIcon.Value = tracking.BugNet.Value;
            bookIcon.Value = tracking.Book.Value;
            shovelIcon.Value = tracking.Shovel.Value;
            flippersIcon.Value = tracking.Flippers.Value;
            armorIcon.Value = tracking.Armor.Value;
            bottleIcon.Value = tracking.BottleCount.Value;
            somariaIcon.Value = tracking.Somaria.Value;
            byrnaIcon.Value = tracking.Byrna.Value;
            capeIcon.Value = tracking.Cape.Value;
            mirrorIcon.Value = tracking.Mirror.Value;
            pearlIcon.Value = tracking.MoonPearl.Value;
        }

        public void UpdateBroadcastView() {
            foreach (InventoryIcon icon in inventoryIcons) {
                icon.UpdateBroadcast();
            }
            foreach (EntranceMedallionIcon icon in entranceIcons) {
                icon.UpdateBroadcast();
            }
        }

        public void ResetInventory() {
            foreach (InventoryIcon icon in inventoryIcons) {
                icon.Value = 0;
                icon.UpdateBroadcast();
            }
            foreach (EntranceMedallionIcon icon in entranceIcons) {
                icon.Value = 0;
                icon.UpdateBroadcast();
            }
        }
    }
}
