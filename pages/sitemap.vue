<template>
  <div>
    <NavSection />
    
    <!-- Sitemap Header -->
    <section class="bg-gray-50 py-16">
      <div class="max-w-4xl mx-auto px-4 sm:px-6 lg:px-8 text-center">
        <Icon name="heroicons:map" class="w-16 h-16 text-gray-700 mx-auto mb-6" />
        <h1 class="text-4xl font-bold text-gray-900 mb-4">
          Site Map
        </h1>
        <p class="text-xl text-gray-600 max-w-2xl mx-auto">
          Navigate through all pages and resources available on True North Federal Solutions website.
        </p>
      </div>
    </section>

    <!-- Sitemap Content -->
    <section class="py-16 bg-white">
      <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
        
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
          
          <!-- Main Navigation -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:home" class="w-5 h-5 mr-2 text-blue-700" />
              Main Pages
            </h3>
            <ul class="space-y-2">
              <li>
                <NuxtLink to="/" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Home
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/about" class="text-blue-700 hover:text-blue-800 hover:underline">
                  About
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/contact" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Contact
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Services -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:briefcase" class="w-5 h-5 mr-2 text-green-700" />
              Services
            </h3>
            <ul class="space-y-2">
              <li>
                <NuxtLink to="/services" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Services Overview
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/contract-setup" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Federal Contract Setup
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/proposal-development" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Proposal Development
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/far-compliance" class="text-blue-700 hover:text-blue-800 hover:underline">
                  FAR Compliance
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/services/bid-no-bid-strategy" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Bid/No-Bid Strategy
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Resources -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:book-open" class="w-5 h-5 mr-2 text-purple-700" />
              Resources
            </h3>
            <ul class="space-y-2">
              <li>
                <NuxtLink to="/resources" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Resource Hub
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/blog" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Blog & Articles
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/guides" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Guides & Templates
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/certifications" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Certification Help
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Certifications -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:trophy" class="w-5 h-5 mr-2 text-yellow-600" />
              Certifications
            </h3>
            <ul class="space-y-2">
              <li>
                <NuxtLink to="/resources/certifications/wosb" class="text-blue-700 hover:text-blue-800 hover:underline">
                  WOSB Certification
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/certifications/vosb" class="text-blue-700 hover:text-blue-800 hover:underline">
                  VOSB Certification
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/resources/certifications/8a" class="text-blue-700 hover:text-blue-800 hover:underline">
                  8(a) Program
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Legal Pages -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:scale" class="w-5 h-5 mr-2 text-gray-600" />
              Legal & Policies
            </h3>
            <ul class="space-y-2">
              <li>
                <NuxtLink to="/privacy" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Privacy Policy
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/terms" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Terms of Service
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/accessibility" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Accessibility Statement
                </NuxtLink>
              </li>
              <li>
                <NuxtLink to="/sitemap" class="text-blue-700 hover:text-blue-800 hover:underline">
                  Site Map
                </NuxtLink>
              </li>
            </ul>
          </div>

          <!-- Coming Soon -->
          <div class="bg-gray-50 rounded-lg p-6">
            <h3 class="text-lg font-bold text-gray-900 mb-4 flex items-center">
              <Icon name="heroicons:cog-6-tooth" class="w-5 h-5 mr-2 text-gray-500" />
              Coming Soon
            </h3>
            <ul class="space-y-2 text-gray-500">
              <li>AI-Powered Assessment Tools</li>
              <li>Client Portal</li>
              <li>Interactive Calculators</li>
              <li>Training Modules</li>
              <li>Webinar Series</li>
            </ul>
          </div>

        </div>

        <!-- Search Section -->
        <div class="mt-16 text-center">
          <div class="bg-blue-50 rounded-lg p-8">
            <Icon name="heroicons:magnifying-glass" class="w-12 h-12 text-blue-700 mx-auto mb-4" />
            <h3 class="text-xl font-bold text-gray-900 mb-4">
              Can't Find What You're Looking For?
            </h3>
            <p class="text-gray-600 mb-6">
              Contact us directly for specific questions about federal contracting or to schedule a consultation.
            </p>
            <NuxtLink 
              to="/contact"
              class="inline-flex items-center justify-center px-6 py-3 bg-blue-700 text-white rounded-md hover:bg-blue-800 transition-colors font-medium"
            >
              <Icon name="heroicons:envelope" class="w-5 h-5 mr-2" />
              Contact Us
            </NuxtLink>
          </div>
        </div>

      </div>
    </section>
  </div>
</template>

<script setup>
// Set page meta for SEO
definePageMeta({
  title: 'Site Map - True North Federal Solutions',
  description: 'Complete site map of True North Federal Solutions website including all pages, services, resources, and guides.'
})

// Set head for SEO
useHead({
  title: 'Site Map - True North Federal Solutions',
  meta: [
    { 
      name: 'description', 
      content: 'Complete site map for True North Federal Solutions. Navigate all pages including federal contracting services, resources, and certification guides.' 
    },
    { 
      name: 'keywords', 
      content: 'site map, navigation, federal contracting services, resources, guides, certifications, True North Federal Solutions' 
    }
  ]
})
</script>