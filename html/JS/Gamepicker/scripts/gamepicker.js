// Laad games in vanuit een JSON-bestand
let games = [];
let cart = [];

// Ophalen van de JSON-data (plaats dit in je script-tag of aparte JS-bestand)
fetch("games.json")
    .then((response) => response.json())
    .then((data) => {
        games = data;
        displayGames(games);
        populateGenres(games);
    });

// Elementen
const overviewDiv = document.getElementById("game-overview");
const cartDiv = document.getElementById("shopping-cart");
const filters = {
    price: document.getElementById("price-filter"),
    genre: document.getElementById("genre-filter"),
    rating: document.getElementById("rating-filter")
};
const priceButton = document.getElementById("calculate-price");

// Toon alle games
function displayGames(gamesList) {
    overviewDiv.innerHTML = "";
    gamesList.forEach((game, index) => {
        const gameDiv = document.createElement("div");
        gameDiv.className = "game-item";
        gameDiv.innerHTML = `
            <h3>${game.title}</h3>
            <p>Prijs: €${game.price.toFixed(2)}</p>
            <p>Genre: ${game.genre}</p>
            <p>Rating: ${game.rating}</p>
            <button onclick="addToCart(${index})">Voeg toe aan winkelmandje</button>
        `;
        overviewDiv.appendChild(gameDiv);
    });
}

// Voeg toe aan winkelmandje
function addToCart(index) {
    const selectedGame = games[index];
    if (!cart.includes(selectedGame)) {
        cart.push(selectedGame);
        alert(`${selectedGame.title} is toegevoegd aan het winkelmandje.`);
    } else {
        alert("Dit spel zit al in je winkelmandje.");
    }
}

// Filters toepassen
function applyFilters() {
    const maxPrice = parseFloat(filters.price.value);
    const genre = filters.genre.value;
    const maxRating = parseInt(filters.rating.value);

    const filteredGames = games.filter((game) => {
        return (
            (isNaN(maxPrice) || game.price <= maxPrice) &&
            (genre === "" || game.genre === genre) &&
            (isNaN(maxRating) || game.rating <= maxRating)
        );
    });
    displayGames(filteredGames);
}

filters.price.addEventListener("input", applyFilters);
filters.genre.addEventListener("change", applyFilters);
filters.rating.addEventListener("input", applyFilters);

// Genre dropdown vullen
function populateGenres(gameList) {
    const genres = [...new Set(gameList.map((g) => g.genre))];
    genres.forEach((genre) => {
        const option = document.createElement("option");
        option.value = genre;
        option.textContent = genre;
        filters.genre.appendChild(option);
    });
}

// Prijs berekenen en winkelmandje tonen
priceButton.addEventListener("click", () => {
    overviewDiv.style.display = "none";
    cartDiv.style.display = "block";
    displayCart();
});

// Winkelmandje tonen
function displayCart() {
    cartDiv.innerHTML = "<h2>Winkelmandje</h2>";
    let total = 0;
    cart.forEach((game, index) => {
        total += game.price;
        const itemDiv = document.createElement("div");
        itemDiv.innerHTML = `
            <p>${game.title} - €${game.price.toFixed(2)} <button onclick="removeFromCart(${index})">Verwijder</button></p>
        `;
        cartDiv.appendChild(itemDiv);
    });
    const totalDiv = document.createElement("div");
    totalDiv.innerHTML = `<h3>Totaalprijs: €${total.toFixed(2)}</h3>`;
    cartDiv.appendChild(totalDiv);
}

// Verwijder uit winkelmandje
function removeFromCart(index) {
    cart.splice(index, 1);
    displayCart();
}