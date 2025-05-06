// games direct als array in JS
const games = [
    { "title": "Counter-Strike: Global Offensive", "price": 0.00, "genre": "FPS", "rating": 4 },
    { "title": "Dota 2", "price": 0.00, "genre": "MOBA", "rating": 3 },
    { "title": "Goose Goose Duck", "price": 4.99, "genre": "Action", "rating": 2 },
    { "title": "Apex Legends", "price": 0.00, "genre": "FPS", "rating": 4 },
    { "title": "PUBG: BATTLEGROUNDS", "price": 29.99, "genre": "FPS", "rating": 5 },
    { "title": "Lost Ark", "price": 49.99, "genre": "Action", "rating": 1 },
    { "title": "Grand Theft Auto V", "price": 29.99, "genre": "FPS", "rating": 3 },
    { "title": "Call of Duty®: Modern Warfare® II | Warzone™ 2.0", "price": 19.99, "genre": "FPS", "rating": 3 },
    { "title": "Team Fortress 2", "price": 0.00, "genre": "FPS", "rating": 5 },
    { "title": "Rust", "price": 39.99, "genre": "Action", "rating": 5 },
    { "title": "Unturned", "price": 0.00, "genre": "RPG", "rating": 1 },
    { "title": "ELDEN RING", "price": 59.99, "genre": "RPG", "rating": 5 },
    { "title": "ARK: Survival Evolved", "price": 10.00, "genre": "RPG", "rating": 1 },
    { "title": "War Thunder", "price": 0.00, "genre": "Simulation", "rating": 2 },
    { "title": "Sid Meier's Civilization VI", "price": 29.99, "genre": "Simulation", "rating": 3 },
    { "title": "Football Manager 2023", "price": 59.99, "genre": "Simulation", "rating": 3 },
    { "title": "Warframe", "price": 0.00, "genre": "Looter-shooter", "rating": 3 },
    { "title": "EA SPORTS™ FIFA 23", "price": 59.99, "genre": "Sport", "rating": 1 },
    { "title": "Destiny 2", "price": 0.00, "genre": "FPS", "rating": 5 },
    { "title": "Red Dead Redemption 2", "price": 59.99, "genre": "RPG", "rating": 4 },
    { "title": "Tom Clancy's Rainbow Six Siege", "price": 19.99, "genre": "Simulation", "rating": 3 },
    { "title": "The Witcher 3: Wild Hunt", "price": 39.99, "genre": "RPG", "rating": 4 },
    { "title": "Terraria", "price": 9.99, "genre": "Sandbox", "rating": 2 },
    { "title": "Stardew Valley", "price": 14.99, "genre": "Sandbox", "rating": 1 },
    { "title": "Left 4 Dead 2", "price": 9.99, "genre": "FPS", "rating": 4 },
    { "title": "Don't Starve Together", "price": 5.09, "genre": "RPG", "rating": 3 },
    { "title": "MIR4", "price": 19.99, "genre": "RPG", "rating": 3 },
    { "title": "PAYDAY 2", "price": 9.99, "genre": "Action", "rating": 2 },
    { "title": "Path of Exile", "price": 0.00, "genre": "RPG", "rating": 4 },
    { "title": "Project Zomboid", "price": 14.99, "genre": "Simulation", "rating": 4 },
    { "title": "Valheim", "price": 19.99, "genre": "Sandbox", "rating": 5 },
    { "title": "DayZ", "price": 44.99, "genre": "Simulation", "rating": 3 }
];

const gameList = document.getElementById("gameList");
const genreFilter = document.getElementById("genreFilter");
const priceFilter = document.getElementById("priceFilter");
const ratingFilter = document.getElementById("ratingFilter");
const cartItems = document.getElementById("cartItems");
const totalPrice = document.getElementById("total-price");
const overview = document.getElementById("overview");
const cart = document.getElementById("cart");

let cartData = [];

// Initialiseer filters en overzicht
window.onload = () => {
    fillGenres();
    renderGames(games);
};

// fillGenres():
function fillGenres() {
    const genres = [...new Set(games.map(game => game.genre))];
    genres.forEach(genre => { // deze 'genre' bestaat alleen binnen deze forEach
        const genreOption = document.createElement("option");
        genreOption.value = genre;
        genreOption.textContent = genre;
        genreFilter.appendChild(genreOption);
    });
}

function renderGames(list) {
    gameList.innerHTML = "";
    list.forEach((game, index) => {
        const div = document.createElement("div");
        div.className = "game-item";
        div.innerHTML = `
            <strong>${game.title}</strong><br>
            Genre: ${game.genre}<br>
            Prijs: €${game.price.toFixed(2)}<br>
            Rating: ${game.rating}<br>
            <button onclick="addToCart(${index})">Voeg toe</button>
        `;
        gameList.appendChild(div);
    });
}

function addToCart(index) {
    const game = games[index];
    let isInCart = false;
    
    // Gebruik forEach om te controleren of het spel al in de winkelmand zit
    cartData.forEach((cartGame) => {
        if (cartGame.title === game.title) {
            isInCart = true;
        }
    });

    if (!isInCart) {
        cartData.push(game);
        alert(`${game.title} toegevoegd aan je winkelmandje.`);
    } else {
        alert(`${game.title} zit al in je winkelmandje.`);
    }
}

// event listener (andere scope):
document.getElementById("applyFilters").addEventListener("click", () => {
    const max = parseFloat(priceFilter.value) || Infinity;
    const genre = genreFilter.value; // deze 'genre' is een aparte variabele
    const minRating = parseInt(ratingFilter.value) || 0;

    const filtered = games.filter(game =>
        game.price <= max &&
        (genre === "" || game.genre === genre) &&
        game.rating >= minRating
    );
    renderGames(filtered);
});

document.getElementById("calculatePrice").addEventListener("click", () => {
    overview.style.display = "none";
    cart.style.display = "block";
    renderCart();
});

document.getElementById("backToOverview").addEventListener("click", () => {
    overview.style.display = "block";
    cart.style.display = "none";
});

function renderCart() {
    cartItems.innerHTML = "";
    let total = 0;
    cartData.forEach((game, i) => {
        const div = document.createElement("div");
        div.className = "cart-item";
        div.innerHTML = `${game.title} - €${game.price.toFixed(2)} <button onclick="removeFromCart(${i})">Verwijder</button>`;
        cartItems.appendChild(div);
        total += game.price;
    });
    totalPrice.textContent = `Totaal: €${total.toFixed(2)}`;
}

function removeFromCart(index) {
    cartData.splice(index, 1);
    renderCart();
}