# Offline page and cache-first strategy

The service worker in `../01_Website-PWA/service-worker.js` caches the HTML, CSS, JavaScript, manifest and offline page during installation. For a cache-first strategy, check the cache before making a network request.

## Example fetch handler
```javascript
self.addEventListener("fetch", event => {
  if (event.request.method !== "GET") return;
  event.respondWith(
    caches.match(event.request).then(cachedResponse => {
      if (cachedResponse) return cachedResponse; // cache first
      return fetch(event.request).catch(() => caches.match("./offline.html"));
    })
  );
});
```

## Practical steps
1. Copy `index.html`, `style.css`, `app.js`, `manifest.json`, `offline.html`, and `service-worker.js` from `01_Website-PWA`.
2. Add any image files you use to the `ASSETS` array in the service worker.
3. Increment the cache version (e.g. `college-pwa-v2`) when changing cached files.
4. Serve from localhost, open once online, then test with DevTools → Network → Offline.
