<template>
  <!-- Not used anywhere yet; safe to keep in repo without rendering -->
  <form class="max-w-md space-y-4" @submit.prevent="onSubmit">
    <div class="space-y-2">
      <label for="email" class="block text-sm font-medium text-gray-700">Email</label>
      <input
        id="email"
        v-model="email"
        type="email"
        required
        class="block w-full rounded-md border-gray-300 focus:border-blue-500 focus:ring-blue-500"
        placeholder="you@example.com"
      />
    </div>

    <div class="grid grid-cols-2 gap-4">
      <div>
        <label for="firstName" class="block text-sm font-medium text-gray-700">First name</label>
        <input
          id="firstName"
          v-model="firstName"
          type="text"
          class="block w-full rounded-md border-gray-300 focus:border-blue-500 focus:ring-blue-500"
          placeholder="Jane"
        />
      </div>
      <div>
        <label for="lastName" class="block text-sm font-medium text-gray-700">Last name</label>
        <input
          id="lastName"
          v-model="lastName"
          type="text"
          class="block w-full rounded-md border-gray-300 focus:border-blue-500 focus:ring-blue-500"
          placeholder="Doe"
        />
      </div>
    </div>

    <button type="submit" class="inline-flex items-center rounded-md bg-blue-600 px-4 py-2 text-white hover:bg-blue-700">
      Subscribe
    </button>

    <p v-if="success" class="text-sm text-green-600">Thanks! Please check your inbox to confirm.</p>
    <p v-if="error" class="text-sm text-red-600">{{ error }}</p>
  </form>
</template>

<script setup lang="ts">
import { ref } from 'vue'

const email = ref('')
const firstName = ref('')
const lastName = ref('')
const success = ref(false)
const error = ref('')

const onSubmit = async () => {
  success.value = false
  error.value = ''
  try {
    const res = await $fetch('/api/subscribe', {
      method: 'POST',
      body: {
        email: email.value,
        firstName: firstName.value || undefined,
        lastName: lastName.value || undefined,
        tags: ['website']
      }
    })
    if ((res as any)?.ok) {
      success.value = true
      email.value = ''
      firstName.value = ''
      lastName.value = ''
    }
  } catch (e: any) {
    error.value = e?.statusMessage || 'Subscription failed. Please try again.'
  }
}
</script>

<style scoped>
/* No additional styles; Tailwind only */
</style>
