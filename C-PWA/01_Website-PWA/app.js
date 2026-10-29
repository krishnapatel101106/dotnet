if ("serviceWorker" in navigator) {
  window.addEventListener("load", async () => {
    try {
      await navigator.serviceWorker.register("./service-worker.js");
      document.querySelector("#status").textContent = "PWA ready. This page can be cached for offline use.";
    } catch (error) {
      document.querySelector("#status").textContent = "Service worker registration failed.";
      console.error(error);
    }
  });
}
