<template>
  <!-- Static-only Mailchimp form (not referenced anywhere). No server required. -->
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

    <button type="submit" class="inline-flex items-center rounded-md bg-blue-600 px-4 py-2 text-white hover:bg-blue-700" :disabled="submitting">
      <span v-if="!submitting">Subscribe</span>
      <span v-else>Submitting…</span>
    </button>

    <p v-if="success" class="text-sm text-green-600">Thanks! Please check your inbox to confirm.</p>
    <p v-if="error" class="text-sm text-red-600">{{ error }}</p>
  </form>
</template>

<script setup lang="ts">
import { ref } from 'vue'

// Mailchimp embed params (not secret; same as Mailchimp's public embed code)
// Replace with your values from Audience > Signup forms > Embedded forms > Copy/paste URL params:
// Example action URL: https://usX.list-manage.com/subscribe/post?u=YOUR_U&id=YOUR_ID
const DATA_CENTER = 'usX' // e.g., 'us21'
const U = 'YOUR_U_KEY'
const ID = 'YOUR_AUDIENCE_ID'

const email = ref('')
const firstName = ref('')
const lastName = ref('')
const success = ref(false)
const error = ref('')
const submitting = ref(false)

// JSONP helper to use Mailchimp's post-json endpoint to avoid CORS/redirect
function jsonp<T = any>(url: string): Promise<T> {
  return new Promise((resolve, reject) => {
    try {
      const cbName = `mc_cb_${Date.now()}_${Math.floor(Math.random() * 10000)}`
      // @ts-ignore
      ;(window as any)[cbName] = (data: T) => {
        resolve(data)
        cleanup()
      }
      const script = document.createElement('script')
      script.src = url + (url.includes('?') ? '&' : '?') + `c=${cbName}`
      script.async = true
      script.onerror = () => {
        reject(new Error('Network error'))
        cleanup()
      }
      document.body.appendChild(script)
      const cleanup = () => {
        try {
          document.body.removeChild(script)
          // @ts-ignore
          delete (window as any)[cbName]
        } catch {}
      }
    } catch (e) {
      reject(e)
    }
  })
}

const onSubmit = async () => {
  success.value = false
  error.value = ''
  submitting.value = true
  try {
    const params = new URLSearchParams({
      u: U,
      id: ID,
      EMAIL: email.value,
      FNAME: firstName.value,
      LNAME: lastName.value
    })
    const url = `https://${DATA_CENTER}.list-manage.com/subscribe/post-json?${params.toString()}`
    const res: any = await jsonp(url)
    if (res?.result === 'success') {
      success.value = true
      email.value = ''
      firstName.value = ''
      lastName.value = ''
    } else {
      error.value = res?.msg?.replace(/<[^>]+>/g, '') || 'Subscription failed.'
    }
  } catch (e: any) {
    error.value = e?.message || 'Subscription failed.'
  } finally {
    submitting.value = false
  }
}
</script>

<style scoped>
/* Tailwind only */
</style>
