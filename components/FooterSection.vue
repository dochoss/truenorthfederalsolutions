<template>
  <footer class="bg-white border-t">
    <div class="max-w-7xl mx-auto py-12 px-4 sm:px-6 lg:px-8">
      <div class="flex items-center justify-between">
        <div class="flex items-center space-x-2">
          <Icon name="heroicons:building-office" class="w-6 h-6 text-primary-600" />
          <span class="text-secondary-900 font-medium">True North Federal Solutions</span>
        </div>
        
        <div class="flex items-center space-x-6">
          <a 
            href="https://linkedin.com" 
            target="_blank" 
            rel="noopener noreferrer"
            class="text-secondary-500 hover:text-secondary-900 transition-colors"
          >
            <Icon name="simple-icons:linkedin" class="w-5 h-5" />
          </a>
          <a 
            href="mailto:contact@truenorthfederalsolutions.com" 
            class="text-secondary-500 hover:text-secondary-900 transition-colors"
          >
            <Icon name="heroicons:envelope" class="w-5 h-5" />
          </a>
          <a 
            href="tel:+1234567890" 
            class="text-secondary-500 hover:text-secondary-900 transition-colors"
          >
            <Icon name="heroicons:phone" class="w-5 h-5" />
          </a>
        </div>
      </div>
      
      <div class="mt-8 border-t pt-8">
        <p class="text-center text-sm text-secondary-500">
          © {{ currentYear }} True North Federal Solutions. All rights reserved. | 
          <NuxtLink to="/privacy" class="hover:text-secondary-700 transition-colors">Privacy Policy</NuxtLink> | 
          <NuxtLink to="/terms" class="hover:text-secondary-700 transition-colors">Terms of Service</NuxtLink>
        </p>
      </div>
    </div>
  </footer>
</template>

<script setup>
// Footer component for True North Federal Solutions
// Updated to follow the design system

const currentYear = new Date().getFullYear()
</script>
