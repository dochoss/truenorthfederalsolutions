// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
    runtimeConfig: {
      // Private server-side only
      mailchimp: {
        apiKey: process.env.MAILCHIMP_API_KEY,
        audienceId: process.env.MAILCHIMP_AUDIENCE_ID,
        serverPrefix: process.env.MAILCHIMP_SERVER_PREFIX
      },
      // Public config (none needed for Mailchimp)
      public: {}
    },
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