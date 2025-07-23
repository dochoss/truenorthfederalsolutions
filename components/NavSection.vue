<template>
  <nav class="bg-white shadow-sm border-b">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
      <div class="flex justify-between h-16">
        <div class="flex items-center">
          <NuxtLink to="/" class="flex items-center space-x-3">
            <NuxtImg src="/logo-side.svg" :placeholder="img(`/logo-side.svg`, { h: 50, f: 'png', q: 50 })"
              alt="True North Federal Solutions Logo" class="h-12 w-auto" />
          </NuxtLink>
        </div>

        <!-- Desktop Navigation -->
        <div class="hidden md:flex items-center space-x-1">
          <NuxtLink to="/"
            class="text-secondary-700 hover:text-primary-700 px-3 py-2 rounded-md text-sm font-medium transition-colors">
            Home
          </NuxtLink>
          <NuxtLink to="/about"
            class="text-secondary-700 hover:text-primary-700 px-3 py-2 rounded-md text-sm font-medium transition-colors">
            About
          </NuxtLink>

          <!-- Services Dropdown -->
          <div class="relative group">
            <button
              class="text-secondary-700 hover:text-primary-700 px-3 py-2 rounded-md text-sm font-medium transition-colors flex items-center"
              @click="toggleServicesDropdown">
              Services
              <Icon name="heroicons:chevron-down" class="w-4 h-4 ml-1" />
            </button>
            <div v-show="servicesDropdownOpen"
              class="absolute left-0 mt-2 w-64 bg-white rounded-md shadow-lg z-50 border">
              <div class="py-2">
                <NuxtLink to="/services"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Services Overview
                </NuxtLink>
                <hr class="my-1">
                <NuxtLink to="/services/contract-setup"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Federal Contract Setup
                </NuxtLink>
                <NuxtLink to="/services/proposal-development"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Proposal Development
                </NuxtLink>
                <NuxtLink to="/services/far-compliance"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  FAR Compliance
                </NuxtLink>
                <NuxtLink to="/services/bid-no-bid-strategy"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Bid/No-Bid Strategy
                </NuxtLink>
              </div>
            </div>
          </div>

          <!-- Resources Dropdown -->
          <div class="relative group">
            <button
              class="text-secondary-700 hover:text-primary-700 px-3 py-2 rounded-md text-sm font-medium transition-colors flex items-center"
              @click="toggleResourcesDropdown">
              Resources
              <Icon name="heroicons:chevron-down" class="w-4 h-4 ml-1" />
            </button>
            <div v-show="resourcesDropdownOpen"
              class="absolute left-0 mt-2 w-56 bg-white rounded-md shadow-lg z-50 border">
              <div class="py-2">
                <NuxtLink to="/resources"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Resource Hub
                </NuxtLink>
                <hr class="my-1">
                <NuxtLink to="/resources/blog"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Blog & Articles
                </NuxtLink>
                <NuxtLink to="/resources/guides"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Guides & Templates
                </NuxtLink>
                <NuxtLink to="/resources/certifications"
                  class="block px-4 py-2 text-sm text-secondary-700 hover:bg-primary-50 hover:text-primary-700"
                  @click="closeDropdowns">
                  Certification Help
                </NuxtLink>
              </div>
            </div>
          </div>

          <Social class="px-2" />

          <NuxtLink to="/contact"
            class="bg-primary-700 text-white hover:bg-primary-800 px-4 py-2 rounded-md text-sm font-medium transition-colors">
            Get Started
          </NuxtLink>
        </div>

        <!-- Mobile menu button -->
        <div class="md:hidden flex items-center">
          <button @click="toggleMobileMenu" class="text-secondary-700 hover:text-primary-700 p-2">
            <Icon name="heroicons:bars-3" v-show="!mobileMenuOpen" class="w-6 h-6" />
            <Icon name="heroicons:x-mark" v-show="mobileMenuOpen" class="w-6 h-6" />
          </button>
        </div>
      </div>

      <!-- Mobile Navigation Menu -->
      <div v-show="mobileMenuOpen" class="md:hidden border-t">
        <div class="px-2 pt-2 pb-3 space-y-1">
          <NuxtLink to="/"
            class="block text-secondary-700 hover:text-primary-700 hover:bg-primary-50 px-3 py-2 rounded-md text-base font-medium"
            @click="closeMobileMenu">
            Home
          </NuxtLink>
          <NuxtLink to="/about"
            class="block text-secondary-700 hover:text-primary-700 hover:bg-primary-50 px-3 py-2 rounded-md text-base font-medium"
            @click="closeMobileMenu">
            About
          </NuxtLink>

          <!-- Mobile Services Section -->
          <div>
            <button @click="toggleMobileServices"
              class="w-full text-left text-secondary-700 hover:text-primary-700 hover:bg-primary-50 px-3 py-2 rounded-md text-base font-medium flex items-center justify-between">
              Services
              <Icon name="heroicons:chevron-down" class="w-4 h-4" :class="{ 'rotate-180': mobileServicesOpen }" />
            </button>
            <div v-show="mobileServicesOpen" class="pl-6 space-y-1">
              <NuxtLink to="/services"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Services Overview
              </NuxtLink>
              <NuxtLink to="/services/contract-setup"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Federal Contract Setup
              </NuxtLink>
              <NuxtLink to="/services/proposal-development"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Proposal Development
              </NuxtLink>
              <NuxtLink to="/services/far-compliance"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                FAR Compliance
              </NuxtLink>
              <NuxtLink to="/services/bid-no-bid-strategy"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Bid/No-Bid Strategy
              </NuxtLink>
            </div>
          </div>

          <!-- Mobile Resources Section -->
          <div>
            <button @click="toggleMobileResources"
              class="w-full text-left text-secondary-700 hover:text-primary-700 hover:bg-primary-50 px-3 py-2 rounded-md text-base font-medium flex items-center justify-between">
              Resources
              <Icon name="heroicons:chevron-down" class="w-4 h-4" :class="{ 'rotate-180': mobileResourcesOpen }" />
            </button>
            <div v-show="mobileResourcesOpen" class="pl-6 space-y-1">
              <NuxtLink to="/resources"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Resource Hub
              </NuxtLink>
              <NuxtLink to="/resources/blog"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Blog & Articles
              </NuxtLink>
              <NuxtLink to="/resources/guides"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Guides & Templates
              </NuxtLink>
              <NuxtLink to="/resources/certifications"
                class="block text-secondary-600 hover:text-primary-700 hover:bg-primary-50 px-3 py-1 rounded-md text-sm"
                @click="closeMobileMenu">
                Certification Help
              </NuxtLink>
            </div>
          </div>

          <NuxtLink to="/contact"
            class="block bg-primary-700 text-white hover:bg-primary-800 px-3 py-2 rounded-md text-base font-medium text-center"
            @click="closeMobileMenu">
            Get Started
          </NuxtLink>
        </div>
      </div>
    </div>
  </nav>
</template>

<script setup lang="ts">
// Navigation component for True North Federal Solutions
// Auto-imported by Nuxt - no need for manual registration

const img = useImage()

// Reactive state for dropdown and mobile menu
const servicesDropdownOpen = ref(false)
const resourcesDropdownOpen = ref(false)
const mobileMenuOpen = ref(false)
const mobileServicesOpen = ref(false)
const mobileResourcesOpen = ref(false)

// Dropdown toggle functions
const toggleServicesDropdown = () => {
  servicesDropdownOpen.value = !servicesDropdownOpen.value
  resourcesDropdownOpen.value = false // Close other dropdown
}

const toggleResourcesDropdown = () => {
  resourcesDropdownOpen.value = !resourcesDropdownOpen.value
  servicesDropdownOpen.value = false // Close other dropdown
}

const closeDropdowns = () => {
  servicesDropdownOpen.value = false
  resourcesDropdownOpen.value = false
}

// Mobile menu functions
const toggleMobileMenu = () => {
  mobileMenuOpen.value = !mobileMenuOpen.value
  if (!mobileMenuOpen.value) {
    mobileServicesOpen.value = false
    mobileResourcesOpen.value = false
  }
}

const closeMobileMenu = () => {
  mobileMenuOpen.value = false
  mobileServicesOpen.value = false
  mobileResourcesOpen.value = false
}

const toggleMobileServices = () => {
  mobileServicesOpen.value = !mobileServicesOpen.value
}

const toggleMobileResources = () => {
  mobileResourcesOpen.value = !mobileResourcesOpen.value
}

// Close dropdowns on route change
const router = useRouter()
router.afterEach(() => {
  closeDropdowns()
  closeMobileMenu()
})

// Close dropdowns when clicking outside
onMounted(() => {
  const handleClickOutside = (event: Event) => {
    // Only close if we clicked completely outside the nav
    if (!event.target || !(event.target as Element).closest('nav')) {
      closeDropdowns()
    }
  }

  document.addEventListener('click', handleClickOutside)

  onUnmounted(() => {
    document.removeEventListener('click', handleClickOutside)
  })
})
</script>

<style>
/* Smooth transition for mobile menu chevrons */
.transition-transform {
  transition: transform 0.2s ease-in-out;
}

.rotate-180 {
  transform: rotate(180deg);
}
</style>
