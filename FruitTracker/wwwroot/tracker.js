const connection =
    new signalR.HubConnectionBuilder()
        .withUrl("/webview")
        .build();

async function start() {
    try {
        await connection.start();
    } catch (err) {
        console.log(err);
        setTimeout(start, 2000);
    }
}

start();

connection.onclose(async () => setTimeout(start, 2000));

connection.on("UpdateItem", updateItem);
connection.on("UpdateKeys", updateKeys);
connection.on("UpdateBigKey", updateBigKey);
connection.on("UpdateDungeonPrize", updateDungeonPrize);

function updateItem(item, images) {
    const $cell = $(`#${item}`);

    $cell.find("img").remove();

    for (const image of images) {
        const img = $('<img>');
        if (item.endsWith("Entrance")) {
            img.addClass("entrance-medallion");
        } else {
            img.addClass("cell-icon");
        }
        img.attr('src', image);
        $cell.append(img);
    }
}

function updateKeys(dungeon, keyCount, hasAll) {
    const $cell = $(`.key-count[data-dungeon='${dungeon}']`);

    $cell.text(keyCount);

    if (hasAll) {
        $cell.addClass("all-keys");
    } else {
        $cell.removeClass("all-keys");
    }
}

function updateDungeonPrize(dungeon, icon, prize) {
    const $dungeon = $(`.dungeon-label-icon[data-dungeon='${dungeon}']`);
    const $prize = $(`.prize-icon[data-dungeon='${dungeon}']`);

    $dungeon.attr('src', icon);
    $prize.attr('src', prize);
}

function updateBigKey(dungeon, hasBigKey) {
    const $cell = $(`.dungeon-item-icon[data-dungeon='${dungeon}']`);

    if (hasBigKey) {
        $cell.attr('src', 'icons/items/bigkey.png');
    } else {
        $cell.attr('src', 'icons/items/no_bigkey.png');
    }
}
