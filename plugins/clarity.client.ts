import Clarity from '@microsoft/clarity'

export default defineNuxtPlugin(() => {
  const config = useRuntimeConfig()
  const projectId = config.public.clarityProjectId as string

  if (!projectId) {
    console.warn('[Clarity] Project ID not configured. Set NUXT_PUBLIC_CLARITY_PROJECT_ID environment variable.')
    return
  }

  // Initialize Clarity
  Clarity.init(projectId)
})
