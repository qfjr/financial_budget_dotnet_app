// This is our AJAX code
var OurRequest = new XMLHttpRequest(); // This is the object that will service our REQUEST to our APP (it contains the methods to do so)
OurRequest.open('Get', 'http://localhost:60961/Home/GetBillInformation'); //***IMPORTANT -- make sure port number is the same
OurRequest.onload = function () {
    console.log(OurRequest.responseText);
}
OurRequest.send();