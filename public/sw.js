// Empty service worker to prevent 404 warnings
// This file exists to handle requests from browser extensions or cached behavior
self.addEventListener('install', () => self.skipWaiting());
self.addEventListener('activate', () => self.clients.claim());
