"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/messages")
    .build();


connection.on("ReceiveMessage", function (message, userName) {
    var div = document.createElement("div");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var usr = userName.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    div.innerHTML = usr+": "+msg + "<hr/>";
    document.getElementById("messages").appendChild(div);
});


connection.on("UserConnected", function (connectionId) {
    var groupElement = document.getElementById("group");
    var option = document.createElement("option");
    option.text = connectionId;
    option.value = connectionId;

    groupElement.add(option);
});

connection.on("UserDisconnected", function (connectionId) {
    var groupElement = getElementById("group");

    for (var i = 0; i < groupElement.length; i++) {
        groupElement.remove(i);
    }
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (event) {
    var message = document.getElementById("message").value;
    var userName = document.getElementById("userName").value; 
    var groupElement = document.getElementById("group");
    var groupValue = groupElement.value;
    if (groupValue == "All" || groupValue == "Myself") {
        var method = groupValue == "All" ? "SendMessageToAll" : "SendMessageToCaller";
        connection.invoke(method, message, userName).catch(function (err) {
            return console.error(err.toString());
        });
    } else if (groupValue == "PrivateGroup")
    {
        connection.invoke("SendMessageToGroup", "PrivateGroup", message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    else {
        connection.invoke("SendMessageToUser", message, groupValue).catch(function (err) {
            return console.error(err.toString());
        });
    }

    event.preventDefault();
});

document.getElementById("joinGroup").addEventListener("click", function (event) {
    connection.invoke("JoinGroup", "PrivateGroup").catch(function (err) {
        return console.error.toString();
});
    event.preventDefault();
});