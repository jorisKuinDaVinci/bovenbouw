var button = document.getElementById("createButton");
var nameList = ["Piet", "Henk", "Pablo", "Escobar", "Bob", "Corbijn"]

button.addEventListener("click", createElementsFromList)

function createElementsFromList() {
        for (let i = 0; i < nameList.length; i++) {
            let newButton = document.createElement("input")
            newButton.setAttribute("type", "button");
            newButton.setAttribute("value", nameList[i]);
            newButton.classList.add("button")
            newButton.addEventListener("click", function(){ 
                andereFunction(nameList[i]);
            });
            document.boby.appendChild(newButton);
        }

}

function andereFunction(name) {
    alert(name);
}