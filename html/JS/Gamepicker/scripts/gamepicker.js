let games = [
    {
        "title": "Counter-Strike: Global Offensive",
        "price": 0.00,
        "genre": "FPS",
        "rating": 4
    },
    {
        "title": "Dota 2",
        "price": 0.00,
        "genre": "MOBA",
        "rating": 3
    },
    {
        "title": "Goose Goose Duck",
        "price": 4.99,
        "genre": "Action",
        "rating": 2
    },
    {
        "title": "Apex Legends",
        "price": 0.00,
        "genre": "FPS",
        "rating": 4
    },
    {
        "title": "PUBG: BATTLEGROUNDS",
        "price": 29.99,
        "genre": "FPS",
        "rating": 5
    },
    {
        "title": "Lost Ark",
        "price": 49.99,
        "genre": "Action",
        "rating": 1
    },
    {
        "title": "Grand Theft Auto V",
        "price": 29.99,
        "genre": "FPS",
        "rating": 3
    },
    {
        "title": "Call of Duty®: Modern Warfare® II | Warzone™ 2.0",
        "price": 19.99,
        "genre": "FPS",
        "rating": 3
    },
    {
        "title": "Team Fortress 2",
        "price": 0.00,
        "genre": "FPS",
        "rating": 5
    },
    {
        "title": "Rust",
        "price": 39.99,
        "genre": "Action",
        "rating": 5
    },
    {
        "title": "Unturned",
        "price": 0.00,
        "genre": "RPG",
        "rating": 1
    },
    {
        "title": "ELDEN RING",
        "price": 59.99,
        "genre": "RPG",
        "rating": 5
    },
    {
        "title": "ARK: Survival Evolved",
        "price": 10.00,
        "genre": "RPG",
        "rating": 1
    },
    {
        "title": "War Thunder",
        "price": 0.00,
        "genre": "Simulation",
        "rating": 2
    },
    {
        "title": "Sid Meier's Civilization VI",
        "price": 29.99,
        "genre": "Simulation",
        "rating": 3
    },
    {
        "title": "Football Manager 2023",
        "price": 59.99,
        "genre": "Simulation",
        "rating": 3
    },
    {
        "title": "Warframe",
        "price": 0.00,
        "genre": "Looter-shooter",
        "rating": 3
    },
    {
        "title": "EA SPORTS™ FIFA 23",
        "price": 59.99,
        "genre": "Sport",
        "rating": 1
    },
    {
        "title": "Destiny 2",
        "price": 0.00,
        "genre": "FPS",
        "rating": 5
    },
    {
        "title": "Red Dead Redemption 2",
        "price": 59.99,
        "genre": "RPG",
        "rating": 4
    },
    {
        "title": "Tom Clancy's Rainbow Six Siege",
        "price": 19.99,
        "genre": "Simulation",
        "rating": 3
    },
    {
        "title": "The Witcher 3: Wild Hunt",
        "price": 39.99,
        "genre": "RPG",
        "rating": 4
    },
    {
        "title": "Terraria",
        "price": 9.99,
        "genre": "Sandbox",
        "rating": 2
    },
    {
        "title": "Stardew Valley",
        "price": 14.99,
        "genre": "Sandbox",
        "rating": 1
    },
    {
        "title": "Left 4 Dead 2",
        "price": 9.99,
        "genre": "FPS",
        "rating": 4
    },
    {
        "title": "Don't Starve Together",
        "price": 5.09,
        "genre": "RPG",
        "rating": 3
    },
    {
        "title": "MIR4",
        "price": 19.99,
        "genre": "RPG",
        "rating": 3
    },
    {
        "title": "PAYDAY 2",
        "price": 9.99,
        "genre": "Action",
        "rating": 2
    },
    {
        "title": "Path of Exile",
        "price": 0.00,
        "genre": "RPG",
        "rating": 4
    },
    {
        "title": "Project Zomboid",
        "price": 14.99,
        "genre": "Simulation",
        "rating": 4
    },
    {
        "title": "Valheim",
        "price": 19.99,
        "genre": "Sandbox",
        "rating": 5
    },
    {
        "title": "DayZ",
        "price": 44.99,
        "genre": "Simulation",
        "rating": 3
    }
];

let winkelMand = [];

let mainContainer = document.getElementById("alleGames");
//console.log(mainContainer);
let winkelMandContainer = document.getElementById("winkelMand");
let cartGames = document.getElementById("cartGames");
console.log(cartGames);
let prijsContainer = document.getElementById("prijs");
let priceFilter = document.getElementById("priceFilter");
let priceFilterButton = document.getElementById("priceFilterButton");
let filterSelect = document.getElementById('filterSelect');

console.log(winkelMandContainer);

let switchCartButton = document.getElementById("switchCart");
switchCartButton.addEventListener("click", function(){
    //winkelmand laten zien (visible class)
    console.log("Show cart clicked");
    winkelMandContainer.classList.toggle("visible");
    winkelMandContainer.classList.toggle("invisible");
    //mainContainer onzichtbaar maken
    mainContainer.classList.toggle("visible");
    mainContainer.classList.toggle("invisible");

    //spellen in winkermandContainer toevoegen
    fillCart()
    //bereken en toon prijs
    calculateShowPrice()
    

    if (winkelMandContainer.classList.contains("visible")) {
        switchCartButton.innerText = "zie overzicht";
    } else {
        switchCartButton.innerText = "zie winkelmand";
    }
})


priceFilterButton.addEventListener("click", function(event) {
    event.preventDefault(); // Voorkomt eventueel submit gedrag

    // Lees prijsfilter en converteer
    let lowerThanPrice = parseFloat(priceFilter.value);

    // Lees genre filter en maak lowercase voor case insensitive check
    let selectedGenre = filterSelect.value.toLowerCase();

    // Filter games op genre en prijs
    let filteredGames = games.filter(function(game){
        let genreMatch = selectedGenre === 'alles' || game.genre.toLowerCase() === selectedGenre;
        let priceMatch = game.price <= lowerThanPrice;
        return genreMatch && priceMatch;
    });

    console.log(filteredGames);
    renderGameList(filteredGames, mainContainer, true);
})

//mijn code
renderGameList(games, mainContainer, true);

function addItem(gameToAdd) {
    if (!winkelMand.some(game => game.title === gameToAdd.title)) {
        winkelMand.push(gameToAdd);
    } else {
        alert("Dit spel zit al in je winkelmand!");
    }
}

function fillCart() {
    console.log("Winkelmand inhoud:", winkelMand);
    //haal de zichtbare lijst leeg
    cartGames.innerHTML = "";
    if (winkelMand.length === 0) {
        cartGames.innerText = "Je winkelmand is leeg.";
        prijsContainer.innerText = "Totaalprijs: € 0.00";
    } else {
        //vul de winkelmand met de spellen uit de lijst
        renderGameList(winkelMand, cartGames, false);
        calculateShowPrice();
    }
}

function removeItem(gameToRemove) {
    alert("je wilt het spelletje " + gameToRemove.title + " verwijderen")
    //verwijder spel met title counterstrike uit de lijst

    //loop over lijst en cotroleer naam
    winkelMand.forEach(function(game, index) {
        if(gameToRemove.title == game.title){
            console.log(index)
            winkelMand.splice(index, 1)
        }
    })
    cartGames.innerHTML = "";
    renderGameList(winkelMand, cartGames, false);
    calculateShowPrice()
}

function calculateShowPrice() {
    let prijs = 0;
    winkelMand.forEach(function(cartItem) {
        console.log("item uit winkelmand = " + cartItem.price)
        prijs += cartItem.price;
        //prijs = prijs + cartItem.price;
    });
    prijsContainer.innerText = "Totaalprijs: € " + prijs.toFixed(2);
}

function renderGameList(listToRender, containerInWichToRender, isNormalRender) {
    containerInWichToRender.innerHTML = "";
    listToRender.forEach(function(game) {
        console.log(game.title)
        let newGroupElem = document.createElement("section");
        newGroupElem.classList.add(isNormalRender ? "game-overview" : "game-cart");

        let newTitleElem = document.createElement("h2");
        newTitleElem.innerText = game.title;
        newGroupElem.appendChild(newTitleElem);

        let newPriceElem = document.createElement("span");
        newPriceElem.innerText = "€ " + game.price.toFixed(2);
        newGroupElem.appendChild(newPriceElem);

        // Genre
        let newGenreElem = document.createElement("p");
        newGenreElem.innerText = "Genre: " + game.genre;
        newGroupElem.appendChild(newGenreElem);

        // Rating
        let newRatingElem = document.createElement("p");
        newRatingElem.innerText = "Rating: " + game.rating;
        newGroupElem.appendChild(newRatingElem);

        // Knoppen afhankelijk van context (overzicht of winkelmand)
        let newButtonElem = document.createElement("button");
        if (isNormalRender) {
            newButtonElem.innerText = "Toevoegen aan winkelwagen";
            newButtonElem.addEventListener("click", function() {
                addItem(game);
            });
        } else {
            newButtonElem.innerText = "Verwijder uit winkelwagen";
            newButtonElem.addEventListener("click", function() {
                removeItem(game);
            });
        }
        newGroupElem.appendChild(newButtonElem);

        // Voeg alle elementen toe aan de container
        containerInWichToRender.appendChild(newGroupElem);
    });
}