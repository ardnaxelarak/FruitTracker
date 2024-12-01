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

connection.on("StartClock", startTimer);
connection.on("StopClock", stopTimer);
connection.on("ResetClock", resetTimer);

var clockStart = null;
var clockBaseTime = 0;
var clockInterval = null;

var timerElement = null;
var centisElement = null;

function fetchElements() {
    timerElement = document.getElementById("timer");
    centisElement = document.getElementById("centis");
}

if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", fetchElements);
} else {
    fetchElements();
}

function startTimer() {
    if (clockStart == null) {
        clockStart = performance.now();
        updateTime();
    }
    if (!clockInterval) {
        clockInterval = setInterval(updateTime, 100);
    }
}

function stopTimer() {
    if (clockStart != null) {
        const clockCurrent = performance.now();
        clockBaseTime += clockCurrent - clockStart;
        clockStart = null;
        updateTime();
    }
    if (clockInterval) {
        clearInterval(clockInterval);
        clockInterval = null;
    }
}

function resetTimer(value) {
    clockStart = null;
    if (clockInterval) {
        clearInterval(clockInterval);
        clockInterval = null;
    }
    clockBaseTime = value || 0;
    updateTime();
}

function updateTime() {
    const clockCurrent = performance.now();
    var elapsed = clockBaseTime;
    if (clockStart != null) {
        elapsed += clockCurrent - clockStart;
    }
    formatTime(elapsed);
}

function formatTime(millis) {
    const total = Math.trunc(Math.abs(millis) / 10);
    const centis = total % 100;
    const seconds = Math.trunc(total / 100) % 60;
    const minutes = Math.trunc(total / 6000) % 60;
    const hours = Math.trunc(total / 360000);
    var text = "";
    if (millis < 0) {
        text += "-";
    }
    text += hours + ":";
    if (minutes < 10) {
        text += "0" + minutes + ":";
    } else {
        text += minutes + ":";
    }
    if (seconds < 10) {
        text += "0" + seconds;
    } else {
        text += seconds;
    }
    timerElement.textContent = text;

    var partials = ".";
    if (centis < 10) {
        partials += "0" + centis;
    } else {
        partials += centis;
    }
    centisElement.textContent = partials;
}
