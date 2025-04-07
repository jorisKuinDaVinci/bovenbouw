const WEATHERURL = 'https://api.openweathermap.org/data/2.5/weather';
 
async function getWeather(city) {
    const key = 'a352db877902bafba7d0ed23e7660331';
    const response = await fetch(`${WEATHERURL}?q=${city}&appid=${key}&units=metric`);
    const data     = await response.json();
    console.log(data);
    loadScreen(data);
}

// maak de functie loadScreen
function loadScreen(weer) {
    console.log(weer);
    place.innerText = weer.name;
    console.log(weer['name']);
    place.innerHTML = weer.name;
    desc.innerText = weer.weather[0].description;
    temperature.innerText = weer.main.temp;
}
 
window.onload = function () {
    getWeather('Zwijndrecht');
}