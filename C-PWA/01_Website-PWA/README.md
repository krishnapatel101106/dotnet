# College/company/hotel website as a PWA

This folder is a reusable PWA template. To answer a company or hotel version of the question, change the headings and content in `index.html`, and update the app name in `manifest.json`.

## Steps
1. Open the folder in VS Code.
2. Add two square PNG icons named `icon-192.png` and `icon-512.png` (192×192 and 512×512). If you do not have icons yet, remove the icon entries temporarily from the manifest until you add them.
3. Start a local server: open a terminal in this folder and run `py -m http.server 5500`.
4. Visit `http://localhost:5500`.
5. In browser DevTools → Application, inspect Manifest and Service Workers.
6. Reload once to cache the assets, then switch DevTools Network to Offline and reload.

Service workers require HTTPS or localhost. Do not open the HTML directly using `file://`.
