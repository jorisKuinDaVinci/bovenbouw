var button = document.getElementById("createButton");
console.log(button);

button.addEventListener("click", createAnotherElement)

function createAnotherElement() {
    var newButton = document.createElement("button")
    newButton.setAttribute("type", "type");
    newButton.setAttribute("value", "click me for an alert");
    newButton.addEventListener("click", function() {
        alert("Button clicked!");
    });
    document.boby.appendChild(newButton); 
}