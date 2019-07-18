window.onload = refreshTime;

function getTime() {
    $.get("https://localhost:5001/Home/GetCurrentTime", function (data) {
        $("#current-time").text(data);
    });
}

function refreshTime() {
    setInterval(getTime, 3000);
}