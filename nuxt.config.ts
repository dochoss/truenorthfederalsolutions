// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
    modules: [
      '@nuxtjs/tailwindcss',
      '@nuxt/image',
      'nuxt-icon'
    ],
    app: {
      head: {
        link: [
          // Ensure favicon paths respect the GitHub Pages base URL
          // NUXT_APP_BASE_URL should include a trailing slash (e.g., "/repo-name/")
          // Fallback to root when not defined (local dev)
          { rel: 'icon', type: 'image/x-icon', href: `${(process.env.NUXT_APP_BASE_URL || '/').replace(/([^/])$/, '$1/') }favicon.ico` },
          { rel: 'apple-touch-icon', href: `${(process.env.NUXT_APP_BASE_URL || '/').replace(/([^/])$/, '$1/') }favicon.ico` }
        ],
        meta: [
          { name: 'theme-color', content: '#ffffff' }
        ]
      }
    },
    postcss: {
      plugins: {
        tailwindcss: {},
        autoprefixer: {},
      },
    },
  })