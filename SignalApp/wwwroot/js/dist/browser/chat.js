
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();     // to jest wszystko z tej biblioteki SignalR.js tam jest ten obiekt SignalR i on ma te metody i funkcje, lecimy z pamięci - wskazujemy mu tylko miejsce / adresten ze startup - tam to skonfigurowaliśmy

connection.start();


$("#sendButton").click(function () {
    connection.invoke("SendMessage", "Pawel", "Hello");    //nasz klient ma uruchomic metodę SendMessage na serverze, i podajemy parametry do tej metody (invoke jest wbudowany i uruchomi SendMessage)

})

connection.on("ReciveMessage", function (user, message) {       //invoke wrzucamy na server i metoda on - ortrzymaj coś z servera/ nasz klient który wysyłą też otrzyma to co wysyła
    alert(user + " " + message);
});

connection.on("ReciveMessage2", function (userId, conId) {       //invoke wrzucamy na server i metoda on - ortrzymaj coś z servera/ nasz klient który wysyłą też otrzyma to co wysyła
    $("[name='" + userId + "']").attr('id', conId);
    $("[name='" + userId + "']").css({ 'color': 'green' });
    console.log(userId);
});

connection.on("ReciveMessage3", function (list) {       //invoke wrzucamy na server i metoda on - ortrzymaj coś z servera/ nasz klient który wysyłą też otrzyma to co wysyła
    console.log(list);
});