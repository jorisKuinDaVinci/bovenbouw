// Ophalen van de JSON-data (plaats dit in je script-tag of aparte JS-bestand)
fetch("games.json")
    .then((response) => response.json())
    .then((data) => {
        games = data;
        displayGames(games);
        populateGenres(games);
    });

// Laad games in vanuit een JSON-bestand
let games = [];
let cart = [];

// Elementreferenties
const overviewSection = document.getElementById('game-overview');
const cartSection = document.getElementById('shopping-cart');
const cartItems = document.getElementById('cart-items');
const totalPriceElement = document.getElementById('total-price');
const genreFilter = document.getElementById('genre-filter');

// Initialiseren
document.getElementById('apply-filters').addEventListener('click', applyFilters);
document.getElementById('calculate-price').addEventListener('click', showCart);
document.getElementById('back-to-overview').addEventListener('click', showOverview);

function init() {
    fillGenreDropdown();
    renderGames(games);
}

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

// Starten
init();