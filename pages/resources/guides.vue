<template>
  <BaseSection spacing="lg" centered>
    <div class="text-center py-12">
      <h2 class="text-2xl font-semibold mb-4">Guides moved</h2>
      <p class="text-gray-600 mb-6">We've moved the Guides & Templates page. Redirecting you now...</p>
      <NuxtLink to="/guides" class="underline text-primary-600">Go to Guides</NuxtLink>
    </div>
  </BaseSection>
</template>

<script setup>
definePageMeta({
  title: 'Guides – Redirecting',
  description: 'This page redirects to the canonical Guides & Templates page.'
})

if (process.client) {
  // Use replace so history doesn't keep this redirect
  window.location.replace('/guides')
}
</script>

