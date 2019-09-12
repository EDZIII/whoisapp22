"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/eventHub").build()

//Disable send button until connection is established
document.getElementById("eventAddButton").disabled = true;

connection.on("ReceiveMessage", function (user, activity, category, time, place, partecipants) {
    var act = activity.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var cat = category.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " wants to do " + act + " on the date: " + time + " where: " + place + " total partecipants allowed: " + partecipants + ". Category: " + cat;

    //here the card is generated
    // var div = document.createElement("div");
    // div.setAttribute("class", "card");
    // var classBody = document.createElement("div");
    // classBody.setAttribute("class", "card-body");
    // var text = document.createElement("p");   
    // p.textContent = "This is some text within a card body.";
    // classBody.append(text);
    // div.append(classBody);
    //document.getElementById("hubLanding").append(div);
    
    var p = document.createElement("p");
    p.textContent = encodedMsg;
    var div = document.createElement("div");
    div.setAttribute("class", "card");
    div.append(p);
    document.getElementById("eventList").appendChild(div);
});

connection.start().then(function () {
    document.getElementById("eventAddButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("eventAddButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var activity = document.getElementById("activityInput").value;
    var category = document.getElementById("categoryInput").value;
    var time = document.getElementById("timeInput").value;
    var place = document.getElementById("placeInput").value;
    var partecipants = document.getElementById("partecipantsInput").value;

    connection.invoke("SendMessage", user, activity, category, time, place, partecipants).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});