var button = document.getElementById("createButton");
var nameList = ["Piet", "Henk", "Pablo", "Escobar", "Bob", "Corbijn"]

button.addEventListener("click", createElementsFromList)

function createElementsFromList() {
    nameList.forEach(function(value) {
            let newButton = document.createElement("input")
            newButton.setAttribute("type", "button");
            newButton.setAttribute("value", value);
            newButton.classList.add("button")
            newButton.addEventListener("click", function(){ 
                andereFunction(value);
            });
            document.boby.appendChild(newButton);
    })

}

function andereFunction(name) {
    alert(name);
}