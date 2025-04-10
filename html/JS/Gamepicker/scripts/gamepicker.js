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

let cart = [];

const overviewSection = document.getElementById('game-overview');
const cartSection = document.getElementById('shopping-cart');
const cartItems = document.getElementById('cart-items');
const totalPriceElement = document.getElementById('total-price');
const genreFilter = document.getElementById('genre-filter');

document.getElementById('apply-filters').addEventListener('click', applyFilters);
document.getElementById('calculate-price').addEventListener('click', showCart);
document.getElementById('back-to-overview').addEventListener('click', showOverview);

fillGenreDropdown();
renderGames(games);

function fillGenreDropdown() {
    const genres = [...new Set(games.map(game => game.genre))];
    genres.forEach(genre => {
        const option = document.createElement('option');
        option.value = genre;
        option.textContent = genre;
        genreFilter.appendChild(option);
    });
}

function renderGames(gameList) {
    overviewSection.innerHTML = '';
    gameList.forEach(game => {
        const div = document.createElement('div');
        div.className = 'game';
        div.innerHTML = `
            <h3>${game.title}</h3>
            <p>Prijs: €${game.price.toFixed(2)}</p>
            <p>Genre: ${game.genre}</p>
            <p>Rating: ${game.rating}</p>
            <button onclick="addToCart('${game.title}')">Toevoegen aan winkelmandje</button>
        `;
        overviewSection.appendChild(div);
    });
}

function addToCart(title) {
    const game = games.find(g => g.title === title);
    if (!cart.includes(game)) {
        cart.push(game);
        alert(`${title} is toegevoegd aan je winkelmandje.`);
    } else {
        alert(`${title} zit al in je winkelmandje.`);
    }
}

function applyFilters() {
    const maxPrice = parseFloat(document.getElementById('price-filter').value) || Infinity;
    const selectedGenre = genreFilter.value;
    const minRating = parseInt(document.getElementById('rating-filter').value) || 0;

    const filtered = games.filter(game =>
        game.price <= maxPrice &&
        (selectedGenre === '' || game.genre === selectedGenre) &&
        game.rating >= minRating
    );
    renderGames(filtered);
}

function showCart() {
    overviewSection.style.display = 'none';
    cartSection.style.display = 'block';
    updateCart();
}

function showOverview() {
    cartSection.style.display = 'none';
    overviewSection.style.display = 'block';
}

function updateCart() {
    cartItems.innerHTML = '';
    let total = 0;
    cart.forEach((game, index) => {
        const li = document.createElement('li');
        li.innerHTML = `${game.title} - €${game.price.toFixed(2)} <button onclick="removeFromCart(${index})">Verwijder</button>`;
        cartItems.appendChild(li);
        total += game.price;
    });
    totalPriceElement.textContent = `Totale prijs: €${total.toFixed(2)}`;
}

function removeFromCart(index) {
    cart.splice(index, 1);
    updateCart();
}