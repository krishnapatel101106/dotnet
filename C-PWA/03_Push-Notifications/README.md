# PWA push notifications — practical notes

A manifest and service worker alone do **not** deliver remote push notifications. A real push system needs:
- HTTPS (localhost is acceptable for development)
- user permission
- a push subscription created by `PushManager`
- a backend server that stores subscriptions and sends messages through a push service
- VAPID keys on the server

## Browser-side permission demo
Add a button to `index.html`:
```html
<button id="notifyButton">Enable notifications</button>
```

Add to `app.js`:
```javascript
const button = document.querySelector("#notifyButton");

button?.addEventListener("click", async () => {
  if (!("Notification" in window)) {
    alert("This browser does not support notifications.");
    return;
  }

  const permission = await Notification.requestPermission();
  if (permission !== "granted") {
    alert("Notification permission was not granted.");
    return;
  }

  // Demonstration of a local notification. This is not remote push.
  const registration = await navigator.serviceWorker.ready;
  await registration.showNotification("College PWA", {
    body: "Notifications are enabled.",
    icon: "./icon-192.png"
  });
});
```

## Steps
1. Use the PWA project in `01_Website-PWA`.
2. Add the button and JavaScript above.
3. Add a valid `icon-192.png`, or remove the `icon` option.
4. Serve on localhost and click the button.
5. For actual push notifications, implement a backend subscription endpoint and push service; do not claim this local notification demo is remote push.
