addEventListener("fetch", event => {
  event.respondWith(handleRequest(event.request))
})

async function handleRequest(request) {
  const result = await WebAssembly.instantiateStreaming(fetch('math.wasm'));
  return new Response(`Resultaat: ${result.instance.exports.add(5, 3)}`);
}